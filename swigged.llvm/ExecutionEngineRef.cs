//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Swigged.LLVM {

public partial struct ExecutionEngineRef : System.IEquatable<ExecutionEngineRef> {
        public ExecutionEngineRef(global::System.IntPtr cPtr)
        {
            Value = cPtr;
        }

        public System.IntPtr Value;

        public bool Equals(ExecutionEngineRef other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ExecutionEngineRef && Equals((ExecutionEngineRef)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(ExecutionEngineRef left, ExecutionEngineRef right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ExecutionEngineRef left, ExecutionEngineRef right)
        {
            return !left.Equals(right);
        }
    
}

}