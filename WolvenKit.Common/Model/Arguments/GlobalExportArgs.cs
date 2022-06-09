using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Global Export Arguments
    /// </summary>
    public class GlobalExportArgs
    {
        /// <summary>
        /// Export Argument Dictionary.
        /// </summary>
        private readonly Dictionary<Type, ExportArgs> _argsList = new()
        {
            { typeof(CommonExportArgs), new CommonExportArgs() },
            { typeof(MorphTargetExportArgs), new MorphTargetExportArgs() },
            { typeof(MlmaskExportArgs), new MlmaskExportArgs() },
            { typeof(XbmExportArgs), new XbmExportArgs() },
            { typeof(MeshExportArgs), new MeshExportArgs() },
            { typeof(AnimationExportArgs), new AnimationExportArgs() },
            { typeof(WemExportArgs), new WemExportArgs() },
            { typeof(OpusExportArgs), new OpusExportArgs() },
            { typeof(EntityExportArgs), new EntityExportArgs() },
        };

        /// <summary>
        /// Register Export Arguments.
        /// </summary>
        /// <param name="exportArgs"></param>
        /// <returns></returns>
        public GlobalExportArgs Register(params ExportArgs[] exportArgs)
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
        public T Get<T>() where T : ExportArgs
        {
            var arg = _argsList[typeof(T)];
            return arg as T;
        }
    }


}
