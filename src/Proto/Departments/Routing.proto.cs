//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Departments/Routing.proto
namespace Diadoc.Api.Proto.Departments
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Routing")]
  public partial class Routing : global::ProtoBuf.IExtensible
  {
    public Routing() {}
    
    private bool _Kpp;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Kpp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Kpp
    {
      get { return _Kpp; }
      set { _Kpp = value; }
    }
    private bool _Address;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool Address
    {
      get { return _Address; }
      set { _Address = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}