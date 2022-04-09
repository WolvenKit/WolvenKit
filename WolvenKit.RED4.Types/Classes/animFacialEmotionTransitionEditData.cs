using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialEmotionTransitionEditData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("toIdleMale")] 
		public CName ToIdleMale
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("facialKeyMale")] 
		public CName FacialKeyMale
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
		[RED("facialKeyFemale")] 
		public CName FacialKeyFemale
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
		[RED("toIdleWeight")] 
		public CFloat ToIdleWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("toIdleNeckWeight")] 
		public CFloat ToIdleNeckWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("customTransitionAnim")] 
		public CName CustomTransitionAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animFacialEmotionTransitionEditData()
		{
			TransitionType = Enums.animFacialEmotionTransitionType.Fast;
			ToIdleWeight = 1.000000F;
			ToIdleNeckWeight = 1.000000F;
			FacialKeyWeight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
