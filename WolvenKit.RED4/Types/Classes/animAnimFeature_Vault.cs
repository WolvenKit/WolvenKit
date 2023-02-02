using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_Vault : animAnimFeature_Climb
	{
		[Ordinal(10)] 
		[RED("landPosition")] 
		public Vector4 LandPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(11)] 
		[RED("travellingTime")] 
		public CFloat TravellingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("obstacleDepth")] 
		public CFloat ObstacleDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_Vault()
		{
			LandPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
