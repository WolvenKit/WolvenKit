namespace WolvenKit.RED4.Types
{
    public partial class AccessPoint
    {
        [RED("baseActionOperations")]
        public CHandle<BaseActionOperations> BaseActionOperations
        {
            get => GetPropertyValue<CHandle<BaseActionOperations>>();
            set => SetPropertyValue<CHandle<BaseActionOperations>>(value);
        }
    }
}
