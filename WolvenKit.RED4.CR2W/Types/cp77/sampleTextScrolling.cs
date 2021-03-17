using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleTextScrolling : inkWidgetLogicController
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

		public sampleTextScrolling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
