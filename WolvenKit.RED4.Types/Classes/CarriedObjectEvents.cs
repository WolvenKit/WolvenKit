using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarriedObjectEvents : OldUpperBodyEventsTransition
	{
		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_Mounting> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_Mounting>>();
			set => SetPropertyValue<CHandle<AnimFeature_Mounting>>(value);
		}

		[Ordinal(1)] 
		[RED("animCarryFeature")] 
		public CHandle<AnimFeature_Carry> AnimCarryFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_Carry>>();
			set => SetPropertyValue<CHandle<AnimFeature_Carry>>(value);
		}

		[Ordinal(2)] 
		[RED("leftHandFeature")] 
		public CHandle<AnimFeature_LeftHandAnimation> LeftHandFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_LeftHandAnimation>>();
			set => SetPropertyValue<CHandle<AnimFeature_LeftHandAnimation>>(value);
		}

		[Ordinal(3)] 
		[RED("AnimWrapperWeightSetterStrong")] 
		public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterStrong
		{
			get => GetPropertyValue<CHandle<entAnimWrapperWeightSetter>>();
			set => SetPropertyValue<CHandle<entAnimWrapperWeightSetter>>(value);
		}

		[Ordinal(4)] 
		[RED("AnimWrapperWeightSetterFriendly")] 
		public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterFriendly
		{
			get => GetPropertyValue<CHandle<entAnimWrapperWeightSetter>>();
			set => SetPropertyValue<CHandle<entAnimWrapperWeightSetter>>(value);
		}

		[Ordinal(5)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("forceStyleName")] 
		public CName ForceStyleName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("isFriendlyCarry")] 
		public CBool IsFriendlyCarry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("forcedCarryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle
		{
			get => GetPropertyValue<CEnum<gamePSMBodyCarryingStyle>>();
			set => SetPropertyValue<CEnum<gamePSMBodyCarryingStyle>>(value);
		}

		public CarriedObjectEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
