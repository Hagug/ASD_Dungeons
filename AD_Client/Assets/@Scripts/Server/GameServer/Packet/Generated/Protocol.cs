//// <auto-generated>
////     Generated by the protocol buffer compiler.  DO NOT EDIT!
////     source: Protocol.proto
//// </auto-generated>
//#pragma warning disable 1591, 0612, 3021
//#region Designer generated code

//using pb = global::Google.Protobuf;
//using pbc = global::Google.Protobuf.Collections;
//using pbr = global::Google.Protobuf.Reflection;
//using scg = global::System.Collections.Generic;
//namespace Google.Protobuf.Protocol {

//  /// <summary>Holder for reflection information generated from Protocol.proto</summary>
//  public static partial class ProtocolReflection {

//    #region Descriptor
//    /// <summary>File descriptor for Protocol.proto</summary>
//    public static pbr::FileDescriptor Descriptor {
//      get { return descriptor; }
//    }
//    private static pbr::FileDescriptor descriptor;

//    static ProtocolReflection() {
//      byte[] descriptorData = global::System.Convert.FromBase64String(
//          string.Concat(
//            "Cg5Qcm90b2NvbC5wcm90bxIIUHJvdG9jb2waCkVudW0ucHJvdG8aDFN0cnVj",
//            "dC5wcm90byINCgtTX0Nvbm5lY3RlZCIWCgZDX1Rlc3QSDAoEdGVtcBgBIAEo",
//            "BUIbqgIYR29vZ2xlLlByb3RvYnVmLlByb3RvY29sUABQAWIGcHJvdG8z"));
//      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
//          new pbr::FileDescriptor[] { global::Google.Protobuf.Protocol.EnumReflection.Descriptor, global::Google.Protobuf.Protocol.StructReflection.Descriptor, },
//          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
//            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.S_Connected), global::Google.Protobuf.Protocol.S_Connected.Parser, null, null, null, null, null),
//            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.Protocol.C_Test), global::Google.Protobuf.Protocol.C_Test.Parser, new[]{ "Temp" }, null, null, null, null)
//          }));
//    }
//    #endregion

//  }
//  #region Messages
//  public sealed partial class S_Connected : pb::IMessage<S_Connected> {
//    private static readonly pb::MessageParser<S_Connected> _parser = new pb::MessageParser<S_Connected>(() => new S_Connected());
//    private pb::UnknownFieldSet _unknownFields;
//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public static pb::MessageParser<S_Connected> Parser { get { return _parser; } }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public static pbr::MessageDescriptor Descriptor {
//      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[0]; }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    pbr::MessageDescriptor pb::IMessage.Descriptor {
//      get { return Descriptor; }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public S_Connected() {
//      OnConstruction();
//    }

//    partial void OnConstruction();

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public S_Connected(S_Connected other) : this() {
//      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public S_Connected Clone() {
//      return new S_Connected(this);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public override bool Equals(object other) {
//      return Equals(other as S_Connected);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public bool Equals(S_Connected other) {
//      if (ReferenceEquals(other, null)) {
//        return false;
//      }
//      if (ReferenceEquals(other, this)) {
//        return true;
//      }
//      return Equals(_unknownFields, other._unknownFields);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public override int GetHashCode() {
//      int hash = 1;
//      if (_unknownFields != null) {
//        hash ^= _unknownFields.GetHashCode();
//      }
//      return hash;
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public override string ToString() {
//      return pb::JsonFormatter.ToDiagnosticString(this);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public void WriteTo(pb::CodedOutputStream output) {
//      if (_unknownFields != null) {
//        _unknownFields.WriteTo(output);
//      }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public int CalculateSize() {
//      int size = 0;
//      if (_unknownFields != null) {
//        size += _unknownFields.CalculateSize();
//      }
//      return size;
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public void MergeFrom(S_Connected other) {
//      if (other == null) {
//        return;
//      }
//      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public void MergeFrom(pb::CodedInputStream input) {
//      uint tag;
//      while ((tag = input.ReadTag()) != 0) {
//        switch(tag) {
//          default:
//            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
//            break;
//        }
//      }
//    }

//  }

//  public sealed partial class C_Test : pb::IMessage<C_Test> {
//    private static readonly pb::MessageParser<C_Test> _parser = new pb::MessageParser<C_Test>(() => new C_Test());
//    private pb::UnknownFieldSet _unknownFields;
//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public static pb::MessageParser<C_Test> Parser { get { return _parser; } }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public static pbr::MessageDescriptor Descriptor {
//      get { return global::Google.Protobuf.Protocol.ProtocolReflection.Descriptor.MessageTypes[1]; }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    pbr::MessageDescriptor pb::IMessage.Descriptor {
//      get { return Descriptor; }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public C_Test() {
//      OnConstruction();
//    }

//    partial void OnConstruction();

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public C_Test(C_Test other) : this() {
//      temp_ = other.temp_;
//      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public C_Test Clone() {
//      return new C_Test(this);
//    }

//    /// <summary>Field number for the "temp" field.</summary>
//    public const int TempFieldNumber = 1;
//    private int temp_;
//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public int Temp {
//      get { return temp_; }
//      set {
//        temp_ = value;
//      }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public override bool Equals(object other) {
//      return Equals(other as C_Test);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public bool Equals(C_Test other) {
//      if (ReferenceEquals(other, null)) {
//        return false;
//      }
//      if (ReferenceEquals(other, this)) {
//        return true;
//      }
//      if (Temp != other.Temp) return false;
//      return Equals(_unknownFields, other._unknownFields);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public override int GetHashCode() {
//      int hash = 1;
//      if (Temp != 0) hash ^= Temp.GetHashCode();
//      if (_unknownFields != null) {
//        hash ^= _unknownFields.GetHashCode();
//      }
//      return hash;
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public override string ToString() {
//      return pb::JsonFormatter.ToDiagnosticString(this);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public void WriteTo(pb::CodedOutputStream output) {
//      if (Temp != 0) {
//        output.WriteRawTag(8);
//        output.WriteInt32(Temp);
//      }
//      if (_unknownFields != null) {
//        _unknownFields.WriteTo(output);
//      }
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public int CalculateSize() {
//      int size = 0;
//      if (Temp != 0) {
//        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Temp);
//      }
//      if (_unknownFields != null) {
//        size += _unknownFields.CalculateSize();
//      }
//      return size;
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public void MergeFrom(C_Test other) {
//      if (other == null) {
//        return;
//      }
//      if (other.Temp != 0) {
//        Temp = other.Temp;
//      }
//      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
//    }

//    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
//    public void MergeFrom(pb::CodedInputStream input) {
//      uint tag;
//      while ((tag = input.ReadTag()) != 0) {
//        switch(tag) {
//          default:
//            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
//            break;
//          case 8: {
//            Temp = input.ReadInt32();
//            break;
//          }
//        }
//      }
//    }

//  }

//  #endregion

//}

//#endregion Designer generated code
