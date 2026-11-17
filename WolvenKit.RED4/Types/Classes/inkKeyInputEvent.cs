using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkKeyInputEvent : inkInputEvent
	{
		[Ordinal(0)] 
		[RED("key")] 
		public CEnum<EInputKey> Key
		{
			get => GetPropertyValue<CEnum<EInputKey>>();
			set => SetPropertyValue<CEnum<EInputKey>>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<EInputAction> Action
		{
			get => GetPropertyValue<CEnum<EInputAction>>();
			set => SetPropertyValue<CEnum<EInputAction>>(value);
		}

		[Ordinal(2)] 
		[RED("character")] 
		public CString Character
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public inkKeyInputEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
