using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CP77.Common.Tools
{
    public static class OozNative
    {
        #region osx

        [DllImport("lib/liboodle.dylib", CallingConvention = CallingConvention.StdCall)]
        public static extern int Kraken_Decompress(
            byte[] buffer, 
            long bufferSize, 
            byte[] outputBuffer, 
            long outputBufferSize);
        
        [DllImport("lib/liboodle.dylib", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetCompressedBufferSizeNeeded(int size);

        [DllImport("lib/liboodle.dylib", CallingConvention = CallingConvention.StdCall)]
        public static extern int Compress(
            int algorithm,
            IntPtr inputBuffer,
            IntPtr outputBuffer,
            int inputSize,
            IntPtr src_window_base,
            IntPtr lrm_org);



        #endregion
    }
}
