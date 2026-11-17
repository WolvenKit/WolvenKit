using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MotionPatternTutorialContextDecisions : InputContextTransitionDecisions
	{
		[Ordinal(0)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>(value);
		}

		[Ordinal(1)] 
		[RED("allowOnlyMotionPatternInputs")] 
		public CBool AllowOnlyMotionPatternInputs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MotionPatternTutorialContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
