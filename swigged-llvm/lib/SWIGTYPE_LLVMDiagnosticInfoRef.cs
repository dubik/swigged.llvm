//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.13
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CSLLVM {

public partial struct SWIGTYPE_LLVMDiagnosticInfoRef : System.IEquatable<SWIGTYPE_LLVMDiagnosticInfoRef> {
		public SWIGTYPE_LLVMDiagnosticInfoRef(global::System.IntPtr cPtr)
		{
			Value = cPtr;
		}

		public System.IntPtr Value;

		public bool Equals(SWIGTYPE_LLVMDiagnosticInfoRef other)
		{
			return Value.Equals(other.Value);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is SWIGTYPE_LLVMDiagnosticInfoRef && Equals((SWIGTYPE_LLVMDiagnosticInfoRef)obj);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public static bool operator ==(SWIGTYPE_LLVMDiagnosticInfoRef left, SWIGTYPE_LLVMDiagnosticInfoRef right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(SWIGTYPE_LLVMDiagnosticInfoRef left, SWIGTYPE_LLVMDiagnosticInfoRef right)
		{
			return !left.Equals(right);
		}
	}

}
