using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleTextScrolling : inkWidgetLogicController
	{
		private inkTextWidgetReference _scrollingText;
		private inkanimPlaybackOptions _infiniteloop;

		[Ordinal(1)] 
		[RED("scrollingText")] 
		public inkTextWidgetReference ScrollingText
		{
			get => GetProperty(ref _scrollingText);
			set => SetProperty(ref _scrollingText, value);
		}

		[Ordinal(2)] 
		[RED("infiniteloop")] 
		public inkanimPlaybackOptions Infiniteloop
		{
			get => GetProperty(ref _infiniteloop);
			set => SetProperty(ref _infiniteloop, value);
		}
	}
}
