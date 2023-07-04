using System;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Global Import Arguments
    /// </summary>
    public class GlobalImportArgs : AbstractGlobalArgs
    {
        public GlobalImportArgs()
        {
            _argsList.Add(typeof(CommonImportArgs), new CommonImportArgs());
            _argsList.Add(typeof(XbmImportArgs), new XbmImportArgs());
            _argsList.Add(typeof(GltfImportArgs), new GltfImportArgs());
            _argsList.Add(typeof(OpusImportArgs), new OpusImportArgs());
            _argsList.Add(typeof(MlmaskImportArgs), new MlmaskImportArgs());
            _argsList.Add(typeof(ReImportArgs), new ReImportArgs());
        }

        /// <summary>
        /// Register Export Arguments.
        /// </summary>
        /// <param name="exportArgs"></param>
        /// <returns></returns>
        public GlobalImportArgs Register(params ImportArgs[] exportArgs) => (GlobalImportArgs)base.Register(exportArgs);
    }
}
