using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetHitIndicatorLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("animationPriority")] 
		public CInt32 AnimationPriority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TargetHitIndicatorLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
