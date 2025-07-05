using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectAction_ChildEffectsMovingInCone : gameEffectPostAction
	{
		[Ordinal(0)] 
		[RED("effectsCount")] 
		public CUInt32 EffectsCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("effectTagInThisFile")] 
		public CName EffectTagInThisFile
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("coneAngle")] 
		public CFloat ConeAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("minEffectDuration")] 
		public CFloat MinEffectDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxEffectDuration")] 
		public CFloat MaxEffectDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("twoDimensional")] 
		public CBool TwoDimensional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("smoothInterpolations")] 
		public CBool SmoothInterpolations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectAction_ChildEffectsMovingInCone()
		{
			EffectsCount = 1;
			ConeAngle = 40.000000F;
			MinEffectDuration = 0.300000F;
			MaxEffectDuration = 1.000000F;
			SmoothInterpolations = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
