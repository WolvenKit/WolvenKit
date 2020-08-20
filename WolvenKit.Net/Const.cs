using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Net
{
    public static class Const
    {
        public static string NsScriptDebugger   = "ScriptDebugger";
        public static string NsScriptProfiler   = "ScriptProfiler";
        public static string NsScriptCompiler   = "ScriptCompiler";
        public static string NsScripts           = "scripts";
        public static string NsRemote            = "Remote";
        public static string NsUtility           = "Utility";
        public static string NsConfig            = "Config";

        public static string CmdBind = "BIND";
        
        public static byte[] PacketHead          = {0xDE, 0xAD}; // DEAD
        public static byte[] PacketTail          = {0xBE, 0xEF}; // BEEF
        
        public static string ScRootPath = "RootPath";

        public static string SdUnfilteredLocals = "UnfilteredLocals";
        public static string SdSortLocals = "SortLocals";
        public static string SdOpcodeRequest = "OpcodeBreakdownRequest";

        public static string SReload = "reload";
        public static string SPkgSync = "pkgSync";

        public static string CfgList = "list";

        public static byte[] TypeByte = {0x81, 0x08};
        public static byte[] TypeStringUtf8 = {0xAC, 0x08};
        public static byte[] TypeStringUtf16 = {0x9C, 0x16};
        public static byte[] TypeInt16 = {0x81, 0x16};
        public static byte[] TypeInt32 = {0x81, 0x32};
        public static byte[] TypeInt64 = {0x81, 0x64};
        public static byte[] TypeUint32 = {0x71, 0x32};
    }
}
