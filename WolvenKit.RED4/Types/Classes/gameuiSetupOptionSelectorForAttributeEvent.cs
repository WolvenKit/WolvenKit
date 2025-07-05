using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSetupOptionSelectorForAttributeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("values")] 
		public CArray<gameuiPhotoModeOptionSelectorData> Values
		{
			get => GetPropertyValue<CArray<gameuiPhotoModeOptionSelectorData>>();
			set => SetPropertyValue<CArray<gameuiPhotoModeOptionSelectorData>>(value);
		}

		[Ordinal(2)] 
		[RED("startDataValue")] 
		public CInt32 StartDataValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("doApply")] 
		public CBool DoApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiSetupOptionSelectorForAttributeEvent()
		{
			Values = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
