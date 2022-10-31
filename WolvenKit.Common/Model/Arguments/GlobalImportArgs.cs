using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Global Export Arguments
    /// </summary>
    public class GlobalImportArgs
    {
        /// <summary>
        /// Export Argument Dictionary.
        /// </summary>
        private readonly Dictionary<Type, ImportArgs> _argsList = new()
        {
            { typeof(CommonImportArgs), new CommonImportArgs() },
            { typeof(XbmImportArgs), new XbmImportArgs() },
            { typeof(GltfImportArgs), new GltfImportArgs() },
            { typeof(OpusImportArgs), new OpusImportArgs() },
            { typeof(MlmaskImportArgs), new MlmaskImportArgs() },
            { typeof(ReImportArgs), new ReImportArgs() },
        };

        /// <summary>
        /// Register Export Arguments.
        /// </summary>
        /// <param name="exportArgs"></param>
        /// <returns></returns>
        public GlobalImportArgs Register(params ImportArgs[] exportArgs)
        {
            foreach (var arg in exportArgs)
            {
                var type = arg.GetType();
                if (_argsList.ContainsKey(type))
                {
                    _argsList[type] = arg;
                }
                else
                {
                    _argsList.Add(type, arg);
                }
            }

            return this;
        }

        /// <summary>
        /// Get Argument.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>() where T : ImportArgs
        {
            var arg = _argsList[typeof(T)];
            return arg as T;
        }
    }


}
