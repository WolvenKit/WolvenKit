using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRandomNewsFeedAnimator : inkWidgetLogicController
	{
		private inkTextWidgetReference _textWidget;
		private CFloat _animDuration;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}

		[Ordinal(2)] 
		[RED("animDuration")] 
		public CFloat AnimDuration
		{
			get => GetProperty(ref _animDuration);
			set => SetProperty(ref _animDuration, value);
		}
	}
}
