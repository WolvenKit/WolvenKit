using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameKeyInputEvent : gameCallbackSystemEvent
	{
		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<EInputAction> Action
		{
			get => GetPropertyValue<CEnum<EInputAction>>();
			set => SetPropertyValue<CEnum<EInputAction>>(value);
		}

		[Ordinal(2)] 
		[RED("key")] 
		public CEnum<EInputKey> Key
		{
			get => GetPropertyValue<CEnum<EInputKey>>();
			set => SetPropertyValue<CEnum<EInputKey>>(value);
		}

		public gameKeyInputEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
