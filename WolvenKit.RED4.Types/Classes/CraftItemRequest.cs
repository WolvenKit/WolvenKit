using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftItemRequest : gamePlayerScriptableSystemRequest
	{
		private CWeakHandle<gameObject> _target;
		private CHandle<gamedataItem_Record> _itemRecord;
		private CInt32 _amount;
		private CInt32 _bulletAmount;

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("itemRecord")] 
		public CHandle<gamedataItem_Record> ItemRecord
		{
			get => GetProperty(ref _itemRecord);
			set => SetProperty(ref _itemRecord, value);
		}

		[Ordinal(3)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(4)] 
		[RED("bulletAmount")] 
		public CInt32 BulletAmount
		{
			get => GetProperty(ref _bulletAmount);
			set => SetProperty(ref _bulletAmount, value);
		}
	}
}
