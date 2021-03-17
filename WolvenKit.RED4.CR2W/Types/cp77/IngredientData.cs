using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IngredientData : CVariable
	{
		private CString _label;
		private CInt32 _quantity;
		private CInt32 _baseQuantity;
		private CInt32 _inventoryQuantity;
		private CHandle<gamedataItem_Record> _id;
		private CString _icon;
		private CEnum<gameItemIconGender> _iconGender;
		private CBool _playerSelectableIngredient;
		private CBool _buyableIngredient;
		private CBool _hasEnoughQuantity;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(2)] 
		[RED("baseQuantity")] 
		public CInt32 BaseQuantity
		{
			get => GetProperty(ref _baseQuantity);
			set => SetProperty(ref _baseQuantity, value);
		}

		[Ordinal(3)] 
		[RED("inventoryQuantity")] 
		public CInt32 InventoryQuantity
		{
			get => GetProperty(ref _inventoryQuantity);
			set => SetProperty(ref _inventoryQuantity, value);
		}

		[Ordinal(4)] 
		[RED("id")] 
		public CHandle<gamedataItem_Record> Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(5)] 
		[RED("icon")] 
		public CString Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(6)] 
		[RED("iconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get => GetProperty(ref _iconGender);
			set => SetProperty(ref _iconGender, value);
		}

		[Ordinal(7)] 
		[RED("playerSelectableIngredient")] 
		public CBool PlayerSelectableIngredient
		{
			get => GetProperty(ref _playerSelectableIngredient);
			set => SetProperty(ref _playerSelectableIngredient, value);
		}

		[Ordinal(8)] 
		[RED("buyableIngredient")] 
		public CBool BuyableIngredient
		{
			get => GetProperty(ref _buyableIngredient);
			set => SetProperty(ref _buyableIngredient, value);
		}

		[Ordinal(9)] 
		[RED("hasEnoughQuantity")] 
		public CBool HasEnoughQuantity
		{
			get => GetProperty(ref _hasEnoughQuantity);
			set => SetProperty(ref _hasEnoughQuantity, value);
		}

		public IngredientData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
