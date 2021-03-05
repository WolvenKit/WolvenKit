using System;
using System.Collections.Generic;

namespace WolvenKit.Net
{
    public static class Commands
    {
        #region Methods

        /// <summary>
        /// Tells the game to send you any events in the specified namespace
        /// </summary>
        /// <param name="nspace">Namespace to listen to</param>
        /// <returns></returns>
        public static byte[] Bind(string nspace)
        {
            return Request.Init()
                    .AppendUtf8(Const.CmdBind)
                    .AppendUtf8(nspace)
                    .End();
        }

        /// <summary>
        /// Runs an exec function from the game
        /// </summary>
        /// <param name="command">The command to be executed</param>
        /// <returns></returns>
        public static byte[] Execute(string command)
        {
            return Request.Init()
                    .AppendUtf8(Const.NsRemote)
                    .AppendInt32(unchecked((Int32)0x12345678))
                    .AppendInt32(unchecked((Int32)0x81160008))
                    .AppendUtf8(command)
                    .End();
        }

        public static List<byte[]> Init()
        {
            return new List<byte[]>()
            {
                Bind(Const.NsScriptCompiler),
                Bind(Const.NsScriptDebugger),
                Bind(Const.NsScriptProfiler),
                Bind(Const.NsScripts),
                Bind(Const.NsUtility),
                Bind(Const.NsRemote),
                Bind(Const.NsConfig)
            };
        }

        /// <summary>
        /// Gets the list of mods installed in game directory
        /// </summary>
        /// <returns></returns>
        public static byte[] Modlis()
        {
            return Request.Init().AppendUtf8(Const.NsScripts).AppendUtf8(Const.SPkgSync).End();
        }

        public static byte[] Opcode(string funcname, string classname = null)
        {
            var req = Request.Init()
                        .AppendUtf8(Const.NsScriptDebugger)
                        .AppendUtf8(Const.SdOpcodeRequest)
                        .AppendUtf16(funcname);
            return classname == null ? req.AppendByte(0).End() : req.AppendByte(1).AppendUtf16(classname).End();
        }

        /// <summary>
        /// Reload game scripts
        /// </summary>
        /// <returns></returns>
        public static byte[] Reload()
        {
            return Request.Init()
                    .AppendUtf8(Const.NsScripts)
                    .AppendUtf8(Const.SReload)
                    .End();
        }

        /// <summary>
        /// Get the root path for scripts
        /// </summary>
        /// <returns></returns>
        public static byte[] RootPath()
        {
            return Request.Init()
                    .AppendUtf8(Const.NsScriptCompiler)
                    .AppendUtf8(Const.ScRootPath)
                    .End();
        }

        public static byte[] SetVar(string section, string name, string value)
        {
            return Request.Init()
                        .AppendUtf8("Config")
                        .AppendInt32(BitConverter.ToInt32(new[] { (byte)0xCC, (byte)0x00, (byte)0xCC, (byte)0x00 }, 0))
                        .AppendUtf8("set")
                        .AppendUtf8(section)
                        .AppendUtf8(name)
                        .AppendUtf16(value)
                        .End();
        }

        /// <summary>
        /// Searches for config variables
        /// </summary>
        /// <param name="section">Section to search. If left empty, searches all sections</param>
        /// <param name="name">Only the variables containing this token will be returned. Leave empty for all variables</param>
        /// <returns></returns>
        public static byte[] Varlist(string section = "", string name = "")
        {
            return Request.Init()
                    .AppendUtf8(Const.NsConfig)
                    .AppendInt32(unchecked((Int32)0xCC00CC00))
                    .AppendUtf8(Const.CfgList)
                    .AppendUtf8(section)
                    .AppendUtf8(name)
                    .End();
        }

        #endregion Methods
    }
}
