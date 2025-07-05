using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNearestRoadFromPlayerInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pathLength")] 
		public CFloat PathLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameNearestRoadFromPlayerInfo()
		{
			PathLength = -1.000000F;
			Point = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
