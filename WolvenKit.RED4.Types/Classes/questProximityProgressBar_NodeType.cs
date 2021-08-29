using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questProximityProgressBar_NodeType : questIUIManagerNodeType
	{
		private CBool _show;
		private CFloat _duration;
		private CBool _reset;
		private CFloat _distance;
		private CEnum<EComparisonType> _distanceComparisonType;
		private gameEntityReference _target;
		private CBool _isPlayerActivator;
		private gameEntityReference _activator;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(4)] 
		[RED("distanceComparisonType")] 
		public CEnum<EComparisonType> DistanceComparisonType
		{
			get => GetProperty(ref _distanceComparisonType);
			set => SetProperty(ref _distanceComparisonType, value);
		}

		[Ordinal(5)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(6)] 
		[RED("isPlayerActivator")] 
		public CBool IsPlayerActivator
		{
			get => GetProperty(ref _isPlayerActivator);
			set => SetProperty(ref _isPlayerActivator, value);
		}

		[Ordinal(7)] 
		[RED("activator")] 
		public gameEntityReference Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}
	}
}
