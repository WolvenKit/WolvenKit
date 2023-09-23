using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCyberspaceUIObject : gameObject
	{
		[Ordinal(36)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(37)] 
		[RED("mappinType")] 
		public CEnum<gameuiCyberspaceElementType> MappinType
		{
			get => GetPropertyValue<CEnum<gameuiCyberspaceElementType>>();
			set => SetPropertyValue<CEnum<gameuiCyberspaceElementType>>(value);
		}

		[Ordinal(38)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiCyberspaceUIObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
