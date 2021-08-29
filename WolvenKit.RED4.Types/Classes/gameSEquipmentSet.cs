using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSEquipmentSet : RedBaseClass
	{
		private CArray<gameSItemInfo> _setItems;
		private CName _setName;
		private CEnum<gameEquipmentSetType> _setType;

		[Ordinal(0)] 
		[RED("setItems")] 
		public CArray<gameSItemInfo> SetItems
		{
			get => GetProperty(ref _setItems);
			set => SetProperty(ref _setItems, value);
		}

		[Ordinal(1)] 
		[RED("setName")] 
		public CName SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get => GetProperty(ref _setType);
			set => SetProperty(ref _setType, value);
		}
	}
}
