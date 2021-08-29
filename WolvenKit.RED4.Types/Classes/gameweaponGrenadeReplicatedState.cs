using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponGrenadeReplicatedState : netIEntityState
	{
		private CWeakHandle<gameObject> _instigator;
		private gameItemID _itemID;
		private WorldTransform _currentTransform;
		private CBool _exploded;
		private CBool _launched;

		[Ordinal(2)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(4)] 
		[RED("currentTransform")] 
		public WorldTransform CurrentTransform
		{
			get => GetProperty(ref _currentTransform);
			set => SetProperty(ref _currentTransform, value);
		}

		[Ordinal(5)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetProperty(ref _exploded);
			set => SetProperty(ref _exploded, value);
		}

		[Ordinal(6)] 
		[RED("launched")] 
		public CBool Launched
		{
			get => GetProperty(ref _launched);
			set => SetProperty(ref _launched, value);
		}
	}
}
