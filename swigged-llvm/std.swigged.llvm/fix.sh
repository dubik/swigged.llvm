
cat sav.cs | sed -e 's/\[global::System.Runtime.InteropServices.DllImport("swigged.llvm.native.so", EntryPoint=["]\([^"]*\)["])]/#if _WINDOWS\n    [global::System.Runtime.InteropServices.DllImport("swigged.llvm.native.dll", EntryPoint="\1")]\n    #else\n    [global::System.Runtime.InteropServices.DllImport("swigged.llvm.native.so", EntryPoint="\1")]\n    #endif/g'
