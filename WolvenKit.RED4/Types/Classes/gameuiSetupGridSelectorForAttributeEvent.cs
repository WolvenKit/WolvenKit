using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSetupGridSelectorForAttributeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameuiSetupGridSelectorForAttributeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
