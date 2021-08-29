using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTimeDisplayLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _timerText;
		private inkTextWidgetReference _noConnectionText;

		[Ordinal(1)] 
		[RED("timerText")] 
		public inkTextWidgetReference TimerText
		{
			get => GetProperty(ref _timerText);
			set => SetProperty(ref _timerText, value);
		}

		[Ordinal(2)] 
		[RED("noConnectionText")] 
		public inkTextWidgetReference NoConnectionText
		{
			get => GetProperty(ref _noConnectionText);
			set => SetProperty(ref _noConnectionText, value);
		}
	}
}
