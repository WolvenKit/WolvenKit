using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_Vault : animAnimFeature_Climb
	{
		private Vector4 _landPosition;
		private CFloat _travellingTime;
		private CFloat _obstacleDepth;

		[Ordinal(10)] 
		[RED("landPosition")] 
		public Vector4 LandPosition
		{
			get => GetProperty(ref _landPosition);
			set => SetProperty(ref _landPosition, value);
		}

		[Ordinal(11)] 
		[RED("travellingTime")] 
		public CFloat TravellingTime
		{
			get => GetProperty(ref _travellingTime);
			set => SetProperty(ref _travellingTime, value);
		}

		[Ordinal(12)] 
		[RED("obstacleDepth")] 
		public CFloat ObstacleDepth
		{
			get => GetProperty(ref _obstacleDepth);
			set => SetProperty(ref _obstacleDepth, value);
		}
	}
}
