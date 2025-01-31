// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/enums/v1/update.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Api.Enums.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/enums/v1/update.proto</summary>
  public static partial class UpdateReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/enums/v1/update.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJ0ZW1wb3JhbC9hcGkvZW51bXMvdjEvdXBkYXRlLnByb3RvEhV0ZW1wb3Jh",
            "bC5hcGkuZW51bXMudjEqjgEKH1dvcmtmbG93VXBkYXRlUmVzdWx0QWNjZXNz",
            "U3R5bGUSMwovV09SS0ZMT1dfVVBEQVRFX1JFU1VMVF9BQ0NFU1NfU1RZTEVf",
            "VU5TUEVDSUZJRUQQABI2CjJXT1JLRkxPV19VUERBVEVfUkVTVUxUX0FDQ0VT",
            "U19TVFlMRV9SRVFVSVJFX0lOTElORRABQoMBChhpby50ZW1wb3JhbC5hcGku",
            "ZW51bXMudjFCC1VwZGF0ZVByb3RvUAFaIWdvLnRlbXBvcmFsLmlvL2FwaS9l",
            "bnVtcy92MTtlbnVtc6oCF1RlbXBvcmFsaW8uQXBpLkVudW1zLlYx6gIaVGVt",
            "cG9yYWxpbzo6QXBpOjpFbnVtczo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Temporalio.Api.Enums.V1.WorkflowUpdateResultAccessStyle), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum WorkflowUpdateResultAccessStyle {
    [pbr::OriginalName("WORKFLOW_UPDATE_RESULT_ACCESS_STYLE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Indicates that the update response _must_ be included as part of the gRPC
    /// response body
    /// </summary>
    [pbr::OriginalName("WORKFLOW_UPDATE_RESULT_ACCESS_STYLE_REQUIRE_INLINE")] RequireInline = 1,
  }

  #endregion

}

#endregion Designer generated code
