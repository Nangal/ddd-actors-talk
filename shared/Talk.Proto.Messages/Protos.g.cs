// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Talk.Proto.Messages {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SCG1lc3NhZ2VzGg90aW1lc3RhbXAucHJvdG8iOwoQ",
            "UmVnaXN0ZXJDdXN0b21lchISCgpDdXN0b21lcklkGAEgASgJEhMKC0Rpc3Bs",
            "YXlOYW1lGAIgASgJIosBCg9SZWdpc3RlclZlaGljbGUSEQoJVmVoaWNsZUlk",
            "GAEgASgJEhIKCkN1c3RvbWVySWQYAiABKAkSFAoMUmVnaXN0cmF0aW9uGAMg",
            "ASgJEhEKCU1ha2VNb2RlbBgEIAEoCRIQCghNYXhTcGVlZBgFIAEoBRIWCg5N",
            "YXhUZW1wZXJhdHVyZRgGIAEoBSJjChhSZWdpc3RlclZlaGljbGVUZWxlbWV0",
            "cnkSEQoJVmVoaWNsZUlkGAEgASgJEhAKCFNlbnNvcklkGAIgASgJEg0KBVNw",
            "ZWVkGAMgASgFEhMKC1RlbXBlcmF0dXJlGAQgASgFIjkKElNlbnNvckluc3Rh",
            "bGxhdGlvbhIQCghTZW5zb3JJZBgBIAEoCRIRCglWZWhpY2xlSWQYAiABKAki",
            "RwoPU2Vuc29yVGVsZW1ldHJ5EhAKCFNlbnNvcklkGAEgASgJEg0KBVNwZWVk",
            "GAIgASgFEhMKC1RlbXBlcmF0dXJlGAMgASgFIhYKA0FjaxIPCgdTdWNjZXNz",
            "GAEgASgIQhaqAhNUYWxrLlByb3RvLk1lc3NhZ2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Talk.Proto.Messages.RegisterCustomer), global::Talk.Proto.Messages.RegisterCustomer.Parser, new[]{ "CustomerId", "DisplayName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Talk.Proto.Messages.RegisterVehicle), global::Talk.Proto.Messages.RegisterVehicle.Parser, new[]{ "VehicleId", "CustomerId", "Registration", "MakeModel", "MaxSpeed", "MaxTemperature" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Talk.Proto.Messages.RegisterVehicleTelemetry), global::Talk.Proto.Messages.RegisterVehicleTelemetry.Parser, new[]{ "VehicleId", "SensorId", "Speed", "Temperature" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Talk.Proto.Messages.SensorInstallation), global::Talk.Proto.Messages.SensorInstallation.Parser, new[]{ "SensorId", "VehicleId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Talk.Proto.Messages.SensorTelemetry), global::Talk.Proto.Messages.SensorTelemetry.Parser, new[]{ "SensorId", "Speed", "Temperature" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Talk.Proto.Messages.Ack), global::Talk.Proto.Messages.Ack.Parser, new[]{ "Success" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RegisterCustomer : pb::IMessage<RegisterCustomer> {
    private static readonly pb::MessageParser<RegisterCustomer> _parser = new pb::MessageParser<RegisterCustomer>(() => new RegisterCustomer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisterCustomer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Talk.Proto.Messages.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterCustomer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterCustomer(RegisterCustomer other) : this() {
      customerId_ = other.customerId_;
      displayName_ = other.displayName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterCustomer Clone() {
      return new RegisterCustomer(this);
    }

    /// <summary>Field number for the "CustomerId" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DisplayName" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisterCustomer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisterCustomer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (DisplayName != other.DisplayName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisterCustomer other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RegisterVehicle : pb::IMessage<RegisterVehicle> {
    private static readonly pb::MessageParser<RegisterVehicle> _parser = new pb::MessageParser<RegisterVehicle>(() => new RegisterVehicle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisterVehicle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Talk.Proto.Messages.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterVehicle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterVehicle(RegisterVehicle other) : this() {
      vehicleId_ = other.vehicleId_;
      customerId_ = other.customerId_;
      registration_ = other.registration_;
      makeModel_ = other.makeModel_;
      maxSpeed_ = other.maxSpeed_;
      maxTemperature_ = other.maxTemperature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterVehicle Clone() {
      return new RegisterVehicle(this);
    }

    /// <summary>Field number for the "VehicleId" field.</summary>
    public const int VehicleIdFieldNumber = 1;
    private string vehicleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VehicleId {
      get { return vehicleId_; }
      set {
        vehicleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CustomerId" field.</summary>
    public const int CustomerIdFieldNumber = 2;
    private string customerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Registration" field.</summary>
    public const int RegistrationFieldNumber = 3;
    private string registration_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Registration {
      get { return registration_; }
      set {
        registration_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MakeModel" field.</summary>
    public const int MakeModelFieldNumber = 4;
    private string makeModel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MakeModel {
      get { return makeModel_; }
      set {
        makeModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MaxSpeed" field.</summary>
    public const int MaxSpeedFieldNumber = 5;
    private int maxSpeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxSpeed {
      get { return maxSpeed_; }
      set {
        maxSpeed_ = value;
      }
    }

    /// <summary>Field number for the "MaxTemperature" field.</summary>
    public const int MaxTemperatureFieldNumber = 6;
    private int maxTemperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxTemperature {
      get { return maxTemperature_; }
      set {
        maxTemperature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisterVehicle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisterVehicle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VehicleId != other.VehicleId) return false;
      if (CustomerId != other.CustomerId) return false;
      if (Registration != other.Registration) return false;
      if (MakeModel != other.MakeModel) return false;
      if (MaxSpeed != other.MaxSpeed) return false;
      if (MaxTemperature != other.MaxTemperature) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VehicleId.Length != 0) hash ^= VehicleId.GetHashCode();
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (Registration.Length != 0) hash ^= Registration.GetHashCode();
      if (MakeModel.Length != 0) hash ^= MakeModel.GetHashCode();
      if (MaxSpeed != 0) hash ^= MaxSpeed.GetHashCode();
      if (MaxTemperature != 0) hash ^= MaxTemperature.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (VehicleId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VehicleId);
      }
      if (CustomerId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CustomerId);
      }
      if (Registration.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Registration);
      }
      if (MakeModel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MakeModel);
      }
      if (MaxSpeed != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MaxSpeed);
      }
      if (MaxTemperature != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MaxTemperature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VehicleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VehicleId);
      }
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (Registration.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Registration);
      }
      if (MakeModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MakeModel);
      }
      if (MaxSpeed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxSpeed);
      }
      if (MaxTemperature != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxTemperature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisterVehicle other) {
      if (other == null) {
        return;
      }
      if (other.VehicleId.Length != 0) {
        VehicleId = other.VehicleId;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.Registration.Length != 0) {
        Registration = other.Registration;
      }
      if (other.MakeModel.Length != 0) {
        MakeModel = other.MakeModel;
      }
      if (other.MaxSpeed != 0) {
        MaxSpeed = other.MaxSpeed;
      }
      if (other.MaxTemperature != 0) {
        MaxTemperature = other.MaxTemperature;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            VehicleId = input.ReadString();
            break;
          }
          case 18: {
            CustomerId = input.ReadString();
            break;
          }
          case 26: {
            Registration = input.ReadString();
            break;
          }
          case 34: {
            MakeModel = input.ReadString();
            break;
          }
          case 40: {
            MaxSpeed = input.ReadInt32();
            break;
          }
          case 48: {
            MaxTemperature = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RegisterVehicleTelemetry : pb::IMessage<RegisterVehicleTelemetry> {
    private static readonly pb::MessageParser<RegisterVehicleTelemetry> _parser = new pb::MessageParser<RegisterVehicleTelemetry>(() => new RegisterVehicleTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisterVehicleTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Talk.Proto.Messages.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterVehicleTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterVehicleTelemetry(RegisterVehicleTelemetry other) : this() {
      vehicleId_ = other.vehicleId_;
      sensorId_ = other.sensorId_;
      speed_ = other.speed_;
      temperature_ = other.temperature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterVehicleTelemetry Clone() {
      return new RegisterVehicleTelemetry(this);
    }

    /// <summary>Field number for the "VehicleId" field.</summary>
    public const int VehicleIdFieldNumber = 1;
    private string vehicleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VehicleId {
      get { return vehicleId_; }
      set {
        vehicleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "SensorId" field.</summary>
    public const int SensorIdFieldNumber = 2;
    private string sensorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SensorId {
      get { return sensorId_; }
      set {
        sensorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Speed" field.</summary>
    public const int SpeedFieldNumber = 3;
    private int speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "Temperature" field.</summary>
    public const int TemperatureFieldNumber = 4;
    private int temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisterVehicleTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisterVehicleTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VehicleId != other.VehicleId) return false;
      if (SensorId != other.SensorId) return false;
      if (Speed != other.Speed) return false;
      if (Temperature != other.Temperature) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VehicleId.Length != 0) hash ^= VehicleId.GetHashCode();
      if (SensorId.Length != 0) hash ^= SensorId.GetHashCode();
      if (Speed != 0) hash ^= Speed.GetHashCode();
      if (Temperature != 0) hash ^= Temperature.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (VehicleId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(VehicleId);
      }
      if (SensorId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SensorId);
      }
      if (Speed != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Speed);
      }
      if (Temperature != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Temperature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VehicleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VehicleId);
      }
      if (SensorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SensorId);
      }
      if (Speed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Speed);
      }
      if (Temperature != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Temperature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisterVehicleTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.VehicleId.Length != 0) {
        VehicleId = other.VehicleId;
      }
      if (other.SensorId.Length != 0) {
        SensorId = other.SensorId;
      }
      if (other.Speed != 0) {
        Speed = other.Speed;
      }
      if (other.Temperature != 0) {
        Temperature = other.Temperature;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            VehicleId = input.ReadString();
            break;
          }
          case 18: {
            SensorId = input.ReadString();
            break;
          }
          case 24: {
            Speed = input.ReadInt32();
            break;
          }
          case 32: {
            Temperature = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SensorInstallation : pb::IMessage<SensorInstallation> {
    private static readonly pb::MessageParser<SensorInstallation> _parser = new pb::MessageParser<SensorInstallation>(() => new SensorInstallation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SensorInstallation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Talk.Proto.Messages.ProtosReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorInstallation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorInstallation(SensorInstallation other) : this() {
      sensorId_ = other.sensorId_;
      vehicleId_ = other.vehicleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorInstallation Clone() {
      return new SensorInstallation(this);
    }

    /// <summary>Field number for the "SensorId" field.</summary>
    public const int SensorIdFieldNumber = 1;
    private string sensorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SensorId {
      get { return sensorId_; }
      set {
        sensorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "VehicleId" field.</summary>
    public const int VehicleIdFieldNumber = 2;
    private string vehicleId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string VehicleId {
      get { return vehicleId_; }
      set {
        vehicleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SensorInstallation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SensorInstallation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SensorId != other.SensorId) return false;
      if (VehicleId != other.VehicleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SensorId.Length != 0) hash ^= SensorId.GetHashCode();
      if (VehicleId.Length != 0) hash ^= VehicleId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SensorId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SensorId);
      }
      if (VehicleId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(VehicleId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SensorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SensorId);
      }
      if (VehicleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VehicleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SensorInstallation other) {
      if (other == null) {
        return;
      }
      if (other.SensorId.Length != 0) {
        SensorId = other.SensorId;
      }
      if (other.VehicleId.Length != 0) {
        VehicleId = other.VehicleId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SensorId = input.ReadString();
            break;
          }
          case 18: {
            VehicleId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SensorTelemetry : pb::IMessage<SensorTelemetry> {
    private static readonly pb::MessageParser<SensorTelemetry> _parser = new pb::MessageParser<SensorTelemetry>(() => new SensorTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SensorTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Talk.Proto.Messages.ProtosReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorTelemetry(SensorTelemetry other) : this() {
      sensorId_ = other.sensorId_;
      speed_ = other.speed_;
      temperature_ = other.temperature_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SensorTelemetry Clone() {
      return new SensorTelemetry(this);
    }

    /// <summary>Field number for the "SensorId" field.</summary>
    public const int SensorIdFieldNumber = 1;
    private string sensorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SensorId {
      get { return sensorId_; }
      set {
        sensorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Speed" field.</summary>
    public const int SpeedFieldNumber = 2;
    private int speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "Temperature" field.</summary>
    public const int TemperatureFieldNumber = 3;
    private int temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SensorTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SensorTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SensorId != other.SensorId) return false;
      if (Speed != other.Speed) return false;
      if (Temperature != other.Temperature) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SensorId.Length != 0) hash ^= SensorId.GetHashCode();
      if (Speed != 0) hash ^= Speed.GetHashCode();
      if (Temperature != 0) hash ^= Temperature.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SensorId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SensorId);
      }
      if (Speed != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Speed);
      }
      if (Temperature != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Temperature);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SensorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SensorId);
      }
      if (Speed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Speed);
      }
      if (Temperature != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Temperature);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SensorTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.SensorId.Length != 0) {
        SensorId = other.SensorId;
      }
      if (other.Speed != 0) {
        Speed = other.Speed;
      }
      if (other.Temperature != 0) {
        Temperature = other.Temperature;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SensorId = input.ReadString();
            break;
          }
          case 16: {
            Speed = input.ReadInt32();
            break;
          }
          case 24: {
            Temperature = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Ack : pb::IMessage<Ack> {
    private static readonly pb::MessageParser<Ack> _parser = new pb::MessageParser<Ack>(() => new Ack());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Ack> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Talk.Proto.Messages.ProtosReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ack() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ack(Ack other) : this() {
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ack Clone() {
      return new Ack(this);
    }

    /// <summary>Field number for the "Success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Ack);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Ack other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Ack other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
