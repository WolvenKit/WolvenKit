using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStateTransitionAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("transition")] 
		public CArray<inkWidgetStateAnimatedTransition> Transition
		{
			get => GetPropertyValue<CArray<inkWidgetStateAnimatedTransition>>();
			set => SetPropertyValue<CArray<inkWidgetStateAnimatedTransition>>(value);
		}

		[Ordinal(2)] 
		[RED("stopActiveAnimation")] 
		public CBool StopActiveAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkStateTransitionAnimationController()
		{
			Transition = new();
			StopActiveAnimation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
