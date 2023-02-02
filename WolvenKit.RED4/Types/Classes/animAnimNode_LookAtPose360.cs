using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("speedInDegreesPerSecond")] 
		public CFloat SpeedInDegreesPerSecond
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("angleOffsetNode")] 
		public animFloatLink AngleOffsetNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(13)] 
		[RED("targetAngleOffsetNode")] 
		public animFloatLink TargetAngleOffsetNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("durationCut")] 
		public CFloat DurationCut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_LookAtPose360()
		{
			Id = 4294967295;
			SpeedInDegreesPerSecond = 120.000000F;
			AngleOffsetNode = new();
			TargetAngleOffsetNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
