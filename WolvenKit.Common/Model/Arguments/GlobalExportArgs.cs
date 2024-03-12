namespace WolvenKit.Common.Model.Arguments
{
    /// <summary>
    /// Global Export Arguments
    /// </summary>
    public class GlobalExportArgs : AbstractGlobalArgs
    {
        public GlobalExportArgs()
        {
            _argsList.Add(typeof(GeneralExportArgs), new GeneralExportArgs());
            _argsList.Add(typeof(CommonExportArgs), new CommonExportArgs());
            _argsList.Add(typeof(MorphTargetExportArgs), new MorphTargetExportArgs());
            _argsList.Add(typeof(MlmaskExportArgs), new MlmaskExportArgs());
            _argsList.Add(typeof(XbmExportArgs), new XbmExportArgs());
            _argsList.Add(typeof(MeshExportArgs), new MeshExportArgs());
            _argsList.Add(typeof(AnimationExportArgs), new AnimationExportArgs());
            _argsList.Add(typeof(WemExportArgs), new WemExportArgs());
            _argsList.Add(typeof(OpusExportArgs), new OpusExportArgs());
            _argsList.Add(typeof(EntityExportArgs), new EntityExportArgs());
            _argsList.Add(typeof(InkAtlasExportArgs), new InkAtlasExportArgs());
            _argsList.Add(typeof(FntExportArgs), new FntExportArgs());
        }

        /// <summary>
        /// Register Export Arguments.
        /// </summary>
        /// <param name="exportArgs"></param>
        /// <returns></returns>
        public GlobalExportArgs Register(params ExportArgs[] exportArgs) => (GlobalExportArgs)base.Register(exportArgs);
    }
}
