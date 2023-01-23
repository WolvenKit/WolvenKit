using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialEmotionTransitionBaked : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("toIdleMale")] 
		public CName ToIdleMale
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("facialKey_Male")] 
		public CName FacialKey_Male
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("toIdleFemale")] 
		public CName ToIdleFemale
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("facialKey_Female")] 
		public CName FacialKey_Female
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("transitionType")] 
		public CEnum<animFacialEmotionTransitionType> TransitionType
		{
			get => GetPropertyValue<CEnum<animFacialEmotionTransitionType>>();
			set => SetPropertyValue<CEnum<animFacialEmotionTransitionType>>(value);
		}

		[Ordinal(5)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("toIdleWeight")] 
		public CFloat ToIdleWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("toIdleNeckWeight")] 
		public CFloat ToIdleNeckWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("customTransitionAnim")] 
		public CName CustomTransitionAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animFacialEmotionTransitionBaked()
		{
			TransitionType = Enums.animFacialEmotionTransitionType.Fast;
			ToIdleWeight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
