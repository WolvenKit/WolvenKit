using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionEquipItemState : gameActionReplicatedState
	{
		private TweakDBID _slotId;
		private gameItemID _itemId;
		private CName _animFeatureNameRight;
		private CName _animFeatureNameLeft;
		private CFloat _duration;
		private CFloat _spawnDelay;

		[Ordinal(5)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(6)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(7)] 
		[RED("animFeatureNameRight")] 
		public CName AnimFeatureNameRight
		{
			get => GetProperty(ref _animFeatureNameRight);
			set => SetProperty(ref _animFeatureNameRight, value);
		}

		[Ordinal(8)] 
		[RED("animFeatureNameLeft")] 
		public CName AnimFeatureNameLeft
		{
			get => GetProperty(ref _animFeatureNameLeft);
			set => SetProperty(ref _animFeatureNameLeft, value);
		}

		[Ordinal(9)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(10)] 
		[RED("spawnDelay")] 
		public CFloat SpawnDelay
		{
			get => GetProperty(ref _spawnDelay);
			set => SetProperty(ref _spawnDelay, value);
		}

		public gameActionEquipItemState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
