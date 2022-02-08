using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("showAnimationName")] 
		public CName ShowAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("hideAnimationName")] 
		public CName HideAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("tooltipAnimHide")] 
		public CHandle<inkanimProxy> TooltipAnimHide
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(4)] 
		[RED("tooltipDelayedShow")] 
		public CHandle<inkanimProxy> TooltipDelayedShow
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(5)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TooltipAnimationController()
		{
			ShowAnimationName = "show_tooltip";
			HideAnimationName = "hide_tooltip";
			AxisDataThreshold = 0.400000F;
		}
	}
}
