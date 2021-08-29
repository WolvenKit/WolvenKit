using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CarriedObjectEvents : OldUpperBodyEventsTransition
	{
		private CHandle<AnimFeature_Mounting> _animFeature;
		private CHandle<AnimFeature_Carry> _animCarryFeature;
		private CHandle<AnimFeature_LeftHandAnimation> _leftHandFeature;
		private CHandle<entAnimWrapperWeightSetter> _animWrapperWeightSetterStrong;
		private CHandle<entAnimWrapperWeightSetter> _animWrapperWeightSetterFriendly;
		private CName _styleName;
		private CName _forceStyleName;
		private CBool _isFriendlyCarry;
		private CEnum<gamePSMBodyCarryingStyle> _forcedCarryStyle;

		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_Mounting> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(1)] 
		[RED("animCarryFeature")] 
		public CHandle<AnimFeature_Carry> AnimCarryFeature
		{
			get => GetProperty(ref _animCarryFeature);
			set => SetProperty(ref _animCarryFeature, value);
		}

		[Ordinal(2)] 
		[RED("leftHandFeature")] 
		public CHandle<AnimFeature_LeftHandAnimation> LeftHandFeature
		{
			get => GetProperty(ref _leftHandFeature);
			set => SetProperty(ref _leftHandFeature, value);
		}

		[Ordinal(3)] 
		[RED("AnimWrapperWeightSetterStrong")] 
		public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterStrong
		{
			get => GetProperty(ref _animWrapperWeightSetterStrong);
			set => SetProperty(ref _animWrapperWeightSetterStrong, value);
		}

		[Ordinal(4)] 
		[RED("AnimWrapperWeightSetterFriendly")] 
		public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterFriendly
		{
			get => GetProperty(ref _animWrapperWeightSetterFriendly);
			set => SetProperty(ref _animWrapperWeightSetterFriendly, value);
		}

		[Ordinal(5)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get => GetProperty(ref _styleName);
			set => SetProperty(ref _styleName, value);
		}

		[Ordinal(6)] 
		[RED("forceStyleName")] 
		public CName ForceStyleName
		{
			get => GetProperty(ref _forceStyleName);
			set => SetProperty(ref _forceStyleName, value);
		}

		[Ordinal(7)] 
		[RED("isFriendlyCarry")] 
		public CBool IsFriendlyCarry
		{
			get => GetProperty(ref _isFriendlyCarry);
			set => SetProperty(ref _isFriendlyCarry, value);
		}

		[Ordinal(8)] 
		[RED("forcedCarryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle
		{
			get => GetProperty(ref _forcedCarryStyle);
			set => SetProperty(ref _forcedCarryStyle, value);
		}
	}
}
