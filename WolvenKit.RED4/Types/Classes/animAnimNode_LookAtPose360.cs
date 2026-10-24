using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("speedInDegreesPerSecond")] 
		public CFloat SpeedInDegreesPerSecond
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("angleOffsetNode")] 
		public animFloatLink AngleOffsetNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(3)] 
		[RED("targetAngleOffsetNode")] 
		public animFloatLink TargetAngleOffsetNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(4)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(5)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("durationCut")] 
		public CFloat DurationCut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_LookAtPose360()
		{
			Id = uint.MaxValue;
			SpeedInDegreesPerSecond = 120.000000F;
			AngleOffsetNode = new animFloatLink();
			TargetAngleOffsetNode = new animFloatLink();
			WeightNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
