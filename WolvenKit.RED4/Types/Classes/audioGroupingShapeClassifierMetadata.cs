using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGroupingShapeClassifierMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("useAngle")] 
		public CBool UseAngle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("minGroupSize")] 
		public CFloat MinGroupSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxGroupSize")] 
		public CFloat MaxGroupSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("minGroupAngleSpread")] 
		public CFloat MinGroupAngleSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxGroupAngleSpread")] 
		public CFloat MaxGroupAngleSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("floorLimit")] 
		public CBool FloorLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("ceilingLimit")] 
		public CBool CeilingLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("minDistanceLimit")] 
		public CName MinDistanceLimit
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("maxDistanceLimit")] 
		public CName MaxDistanceLimit
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioGroupingShapeClassifierMetadata()
		{
			MinDistanceLimit = "near";
			MaxDistanceLimit = "infinite";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
