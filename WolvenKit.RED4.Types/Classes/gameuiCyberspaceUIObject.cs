using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCyberspaceUIObject : gameObject
	{
		[Ordinal(40)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("mappinType")] 
		public CEnum<gameuiCyberspaceElementType> MappinType
		{
			get => GetPropertyValue<CEnum<gameuiCyberspaceElementType>>();
			set => SetPropertyValue<CEnum<gameuiCyberspaceElementType>>(value);
		}

		[Ordinal(42)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
