using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AbilityData : RedBaseClass
	{
		private CBool _empty;
		private gameItemID _iD;
		private CString _name;
		private CString _iconPath;
		private CString _categoryName;
		private CString _description;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CBool _isEquipped;
		private CHandle<gameItemData> _gameItemData;
		private CInt32 _assignedIndex;

		[Ordinal(0)] 
		[RED("Empty")] 
		public CBool Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		[Ordinal(1)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(2)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(3)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(4)] 
		[RED("CategoryName")] 
		public CString CategoryName
		{
			get => GetProperty(ref _categoryName);
			set => SetProperty(ref _categoryName, value);
		}

		[Ordinal(5)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(6)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(7)] 
		[RED("IsEquipped")] 
		public CBool IsEquipped
		{
			get => GetProperty(ref _isEquipped);
			set => SetProperty(ref _isEquipped, value);
		}

		[Ordinal(8)] 
		[RED("GameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(9)] 
		[RED("AssignedIndex")] 
		public CInt32 AssignedIndex
		{
			get => GetProperty(ref _assignedIndex);
			set => SetProperty(ref _assignedIndex, value);
		}

		public AbilityData()
		{
			_empty = true;
			_equipmentArea = new() { Value = Enums.gamedataEquipmentArea.Invalid };
			_assignedIndex = -1;
		}
	}
}
