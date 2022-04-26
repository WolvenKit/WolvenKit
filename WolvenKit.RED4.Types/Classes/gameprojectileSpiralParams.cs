using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileSpiralParams : IScriptable
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("cycleTimeMin")] 
		public CFloat CycleTimeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cycleTimeMax")] 
		public CFloat CycleTimeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rampUpDistanceStart")] 
		public CFloat RampUpDistanceStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("rampUpDistanceEnd")] 
		public CFloat RampUpDistanceEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("rampDownDistanceStart")] 
		public CFloat RampDownDistanceStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("rampDownDistanceEnd")] 
		public CFloat RampDownDistanceEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("rampDownFactor")] 
		public CFloat RampDownFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("randomizePhase")] 
		public CBool RandomizePhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("randomizeDirection")] 
		public CBool RandomizeDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameprojectileSpiralParams()
		{
			CycleTimeMin = 0.100000F;
			CycleTimeMax = 0.100000F;
			RampUpDistanceEnd = 1.000000F;
			RampDownDistanceStart = 1.000000F;
			RampDownDistanceEnd = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
