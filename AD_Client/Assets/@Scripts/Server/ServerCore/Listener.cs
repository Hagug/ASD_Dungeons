using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
	public class Listener
	{
		Socket _listenSocket;
		Func<Session> _sessionFactory;

		public void Init(IPEndPoint endPoint, Func<Session> sessionFactory, int register = 10, int backlog = 100)
		{
			_listenSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			_sessionFactory += sessionFactory;

            // endPoint : 서버의 ip주소와 포트번호 (ex. 127.0.0.1:7777)
            // Bind : 소켓을 endPoint에 등록해 연결 요청을 수신할 수 있게끔 함.
            _listenSocket.Bind(endPoint);

			// backlog : 최대 대기수
			// Listen : 바인딩된 소켓이 연결 요청을 계속해서 감시함.
			_listenSocket.Listen(backlog);

            // register : 동시에 처리할 수 있는 연결 요청의 최댓값
            // args : 클라의 연결 요청을 처리할 수 있는 객체
            for (int i = 0; i < register; i++)
			{
				SocketAsyncEventArgs args = new SocketAsyncEventArgs();
				args.Completed += new EventHandler<SocketAsyncEventArgs>(OnAcceptCompleted);
				RegisterAccept(args);
			}
		}

		void RegisterAccept(SocketAsyncEventArgs args)
		{
			args.AcceptSocket = null;

			bool pending = _listenSocket.AcceptAsync(args);
			if (pending == false)
				OnAcceptCompleted(null, args);
		}

		void OnAcceptCompleted(object sender, SocketAsyncEventArgs args)
		{
			try
			{
				if (args.SocketError == SocketError.Success)
				{
					Session session = _sessionFactory.Invoke();
					session.Start(args.AcceptSocket);
					session.OnConnected(args.AcceptSocket.RemoteEndPoint);
				}
				else
					Console.WriteLine(args.SocketError.ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}			

			RegisterAccept(args);
		}
	}
}
