using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RecipeData : IScriptable
	{
		private CString _label;
		private CArray<IngredientData> _ingredients;
		private CString _icon;
		private CEnum<gameItemIconGender> _iconGender;
		private CString _description;
		private CString _type;
		private CHandle<gamedataItem_Record> _id;
		private CBool _isCraftable;
		private InventoryItemData _inventoryItem;
		private CHandle<gameItemData> _gameItemData;
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("ingredients")] 
		public CArray<IngredientData> Ingredients
		{
			get => GetProperty(ref _ingredients);
			set => SetProperty(ref _ingredients, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CString Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("iconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetProperty(ref _iconGender);
			set => SetProperty(ref _iconGender, value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CString Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(6)] 
		[RED("id")] 
		public CHandle<gamedataItem_Record> Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(7)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetProperty(ref _isCraftable);
			set => SetProperty(ref _isCraftable, value);
		}

		[Ordinal(8)] 
		[RED("inventoryItem")] 
		public InventoryItemData InventoryItem
		{
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(9)] 
		[RED("gameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(10)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public RecipeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
