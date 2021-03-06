//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SignatureVerificationResult.proto
// Note: requires additional types generated from: Timestamp.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SignatureVerificationResult")]
  public partial class SignatureVerificationResult : global::ProtoBuf.IExtensible
  {
    public SignatureVerificationResult() {}
    
    private bool _IsValid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsValid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsValid
    {
      get { return _IsValid; }
      set { _IsValid = value; }
    }

    private Diadoc.Api.Proto.CertificateVerificationResult _CertificateStatus = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CertificateStatus", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.CertificateVerificationResult CertificateStatus
    {
      get { return _CertificateStatus; }
      set { _CertificateStatus = value; }
    }

    private Diadoc.Api.Proto.Timestamp _SignatureTimestamp = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SignatureTimestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp SignatureTimestamp
    {
      get { return _SignatureTimestamp; }
      set { _SignatureTimestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CertificateVerificationResult")]
  public partial class CertificateVerificationResult : global::ProtoBuf.IExtensible
  {
    public CertificateVerificationResult() {}
    
    private bool _IsValid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"IsValid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsValid
    {
      get { return _IsValid; }
      set { _IsValid = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.CertificateChainElement> _CertificateChain = new global::System.Collections.Generic.List<Diadoc.Api.Proto.CertificateChainElement>();
    [global::ProtoBuf.ProtoMember(3, Name=@"CertificateChain", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.CertificateChainElement> CertificateChain
    {
      get { return _CertificateChain; }
    }
  
    private Diadoc.Api.Proto.Timestamp _VerificationTime;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"VerificationTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Timestamp VerificationTime
    {
      get { return _VerificationTime; }
      set { _VerificationTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CertificateChainElement")]
  public partial class CertificateChainElement : global::ProtoBuf.IExtensible
  {
    public CertificateChainElement() {}
    
    private int _CertificateChainStatusFlags;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"CertificateChainStatusFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int CertificateChainStatusFlags
    {
      get { return _CertificateChainStatusFlags; }
      set { _CertificateChainStatusFlags = value; }
    }
    private byte[] _DerCertificate;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DerCertificate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] DerCertificate
    {
      get { return _DerCertificate; }
      set { _DerCertificate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}