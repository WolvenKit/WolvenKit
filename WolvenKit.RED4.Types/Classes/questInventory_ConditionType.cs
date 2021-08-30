using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInventory_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private TweakDBID _itemID;
		private CName _itemTag;
		private CUInt32 _quantity;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(3)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get => GetProperty(ref _itemTag);
			set => SetProperty(ref _itemTag, value);
		}

		[Ordinal(4)] 
		[RED("quantity")] 
		public CUInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(5)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		public questInventory_ConditionType()
		{
			_isPlayer = true;
			_comparisonType = new() { Value = Enums.EComparisonType.Equal };
		}
	}
}
