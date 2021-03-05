namespace WolvenKit.Common.Model.Cr2w
{
    public interface ICR2WCopyAction
    {
        #region Properties

        //public IWolvenkitFile SourceFile { get; set; }
        //public IWolvenkitFile DestinationFile { get; set; }
        public IEditableVariable Parent { get; set; }

        #endregion Properties

        #region Methods

        public ICR2WExport TryLookupReference(ICR2WExport oldExportWrapper, IEditableVariable targetVariable = null);

        #endregion Methods
    }
}
