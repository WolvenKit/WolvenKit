using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionUnequipItemState : gameActionReplicatedState
	{
		private TweakDBID _slotId;
		private CName _animFeatureNameRight;
		private CName _animFeatureNameLeft;
		private CFloat _duration;

		[Ordinal(5)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(6)] 
		[RED("animFeatureNameRight")] 
		public CName AnimFeatureNameRight
		{
			get => GetProperty(ref _animFeatureNameRight);
			set => SetProperty(ref _animFeatureNameRight, value);
		}

		[Ordinal(7)] 
		[RED("animFeatureNameLeft")] 
		public CName AnimFeatureNameLeft
		{
			get => GetProperty(ref _animFeatureNameLeft);
			set => SetProperty(ref _animFeatureNameLeft, value);
		}

		[Ordinal(8)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public gameActionUnequipItemState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
