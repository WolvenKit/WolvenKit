using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSItemStack : RedBaseClass
	{
		private gameItemID _itemID;
		private CInt32 _quantity;
		private CInt32 _powerLevel;
		private TweakDBID _vendorItemID;
		private CBool _isAvailable;
		private gameSItemStackRequirementData _requirement;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(2)] 
		[RED("powerLevel")] 
		public CInt32 PowerLevel
		{
			get => GetProperty(ref _powerLevel);
			set => SetProperty(ref _powerLevel, value);
		}

		[Ordinal(3)] 
		[RED("vendorItemID")] 
		public TweakDBID VendorItemID
		{
			get => GetProperty(ref _vendorItemID);
			set => SetProperty(ref _vendorItemID, value);
		}

		[Ordinal(4)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}

		[Ordinal(5)] 
		[RED("requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get => GetProperty(ref _requirement);
			set => SetProperty(ref _requirement, value);
		}

		public gameSItemStack()
		{
			_quantity = 1;
			_isAvailable = true;
		}
	}
}
