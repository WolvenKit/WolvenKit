using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasPositionFarFromThreat : AIbehaviorconditionScript
	{
		private CFloat _desiredDistance;
		private CFloat _minDistance;
		private CFloat _minPathLength;
		private CFloat _distanceFromTraffic;

		[Ordinal(0)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(2)] 
		[RED("minPathLength")] 
		public CFloat MinPathLength
		{
			get => GetProperty(ref _minPathLength);
			set => SetProperty(ref _minPathLength, value);
		}

		[Ordinal(3)] 
		[RED("distanceFromTraffic")] 
		public CFloat DistanceFromTraffic
		{
			get => GetProperty(ref _distanceFromTraffic);
			set => SetProperty(ref _distanceFromTraffic, value);
		}
	}
}
