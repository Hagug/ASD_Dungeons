using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Server.Game;
using Azure.Core;
using System.Collections.Concurrent;
using Server.Data;

namespace GameServer
{
    // GameLogic
    // - GameRoom
    // -- Zone
    public class GameLogic : JobSerializer
    {
        // 게임의 메인 쓰레드
        public static GameLogic Instance { get; } = new GameLogic();

        // 게임 관리
        static Dictionary<int, GameRoom> _rooms;
        static int _roomIdGenerator = 1;
        static int _threadCount;

        static ConcurrentQueue<GameRoom> _updateQueue;

        public void Update()
        {

        }

        //public GameLogic()
        //{
        //    _rooms = new Dictionary<int, GameRoom>();
        //    _roomIdGenerator = 1;
        //    _updateQueue = new ConcurrentQueue<GameRoom>();

        //    foreach (RoomData roomData in DataManager.RoomDict.Values)
        //    {

        //    }
        //}
    }
}
