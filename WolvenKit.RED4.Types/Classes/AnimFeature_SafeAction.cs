using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SafeAction : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("triggerHeld")] 
		public CBool TriggerHeld
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("safeActionDuration")] 
		public CFloat SafeActionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_SafeAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
