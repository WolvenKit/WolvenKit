using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSEquipmentSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("setItems")] 
		public CArray<gameSItemInfo> SetItems
		{
			get => GetPropertyValue<CArray<gameSItemInfo>>();
			set => SetPropertyValue<CArray<gameSItemInfo>>(value);
		}

		[Ordinal(1)] 
		[RED("setName")] 
		public CName SetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get => GetPropertyValue<CEnum<gameEquipmentSetType>>();
			set => SetPropertyValue<CEnum<gameEquipmentSetType>>(value);
		}

		public gameSEquipmentSet()
		{
			SetItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
