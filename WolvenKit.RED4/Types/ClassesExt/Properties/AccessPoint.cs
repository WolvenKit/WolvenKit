namespace WolvenKit.RED4.Types
{
    public partial class AccessPoint
    {
        [RED("baseStateOperations")]
        public CHandle<BaseStateOperations> BaseStateOperations
        {
            get => GetPropertyValue<CHandle<BaseStateOperations>>();
            set => SetPropertyValue<CHandle<BaseStateOperations>>(value);
        }

        [RED("baseActionOperations")]
        public CHandle<BaseActionOperations> BaseActionOperations
        {
            get => GetPropertyValue<CHandle<BaseActionOperations>>();
            set => SetPropertyValue<CHandle<BaseActionOperations>>(value);
        }

        [RED("interactionAreaOperations")]
        public CHandle<InteractionAreaOperations> InteractionAreaOperations
        {
            get => GetPropertyValue<CHandle<InteractionAreaOperations>>();
            set => SetPropertyValue<CHandle<InteractionAreaOperations>>(value);
        }
    }
}
