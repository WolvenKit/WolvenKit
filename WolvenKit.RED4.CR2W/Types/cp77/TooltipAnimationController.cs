using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipAnimationController : inkWidgetLogicController
	{
		private CName _showAnimationName;
		private CName _hideAnimationName;
		private CHandle<inkanimProxy> _tooltipAnimHide;
		private CHandle<inkanimProxy> _tooltipDelayedShow;
		private CFloat _axisDataThreshold;
		private CBool _isHidden;

		[Ordinal(1)] 
		[RED("showAnimationName")] 
		public CName ShowAnimationName
		{
			get => GetProperty(ref _showAnimationName);
			set => SetProperty(ref _showAnimationName, value);
		}

		[Ordinal(2)] 
		[RED("hideAnimationName")] 
		public CName HideAnimationName
		{
			get => GetProperty(ref _hideAnimationName);
			set => SetProperty(ref _hideAnimationName, value);
		}

		[Ordinal(3)] 
		[RED("tooltipAnimHide")] 
		public CHandle<inkanimProxy> TooltipAnimHide
		{
			get => GetProperty(ref _tooltipAnimHide);
			set => SetProperty(ref _tooltipAnimHide, value);
		}

		[Ordinal(4)] 
		[RED("tooltipDelayedShow")] 
		public CHandle<inkanimProxy> TooltipDelayedShow
		{
			get => GetProperty(ref _tooltipDelayedShow);
			set => SetProperty(ref _tooltipDelayedShow, value);
		}

		[Ordinal(5)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get => GetProperty(ref _axisDataThreshold);
			set => SetProperty(ref _axisDataThreshold, value);
		}

		[Ordinal(6)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		public TooltipAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
