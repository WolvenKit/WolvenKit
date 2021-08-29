using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AINavigationSystemQuery : RedBaseClass
	{
		private AIPositionSpec _source;
		private AIPositionSpec _target;
		private CArray<CName> _allowedTags;
		private CArray<CName> _blockedTags;
		private CFloat _minDesiredDistance;
		private CFloat _maxDesiredDistance;
		private CBool _useFollowSlots;
		private CBool _usePredictionTime;

		[Ordinal(0)] 
		[RED("source")] 
		public AIPositionSpec Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("allowedTags")] 
		public CArray<CName> AllowedTags
		{
			get => GetProperty(ref _allowedTags);
			set => SetProperty(ref _allowedTags, value);
		}

		[Ordinal(3)] 
		[RED("blockedTags")] 
		public CArray<CName> BlockedTags
		{
			get => GetProperty(ref _blockedTags);
			set => SetProperty(ref _blockedTags, value);
		}

		[Ordinal(4)] 
		[RED("minDesiredDistance")] 
		public CFloat MinDesiredDistance
		{
			get => GetProperty(ref _minDesiredDistance);
			set => SetProperty(ref _minDesiredDistance, value);
		}

		[Ordinal(5)] 
		[RED("maxDesiredDistance")] 
		public CFloat MaxDesiredDistance
		{
			get => GetProperty(ref _maxDesiredDistance);
			set => SetProperty(ref _maxDesiredDistance, value);
		}

		[Ordinal(6)] 
		[RED("useFollowSlots")] 
		public CBool UseFollowSlots
		{
			get => GetProperty(ref _useFollowSlots);
			set => SetProperty(ref _useFollowSlots, value);
		}

		[Ordinal(7)] 
		[RED("usePredictionTime")] 
		public CBool UsePredictionTime
		{
			get => GetProperty(ref _usePredictionTime);
			set => SetProperty(ref _usePredictionTime, value);
		}
	}
}
