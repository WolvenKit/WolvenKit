using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSetupOptionButtonForAttributeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiSetupOptionButtonForAttributeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
