using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRandomNewsFeedAnimator : inkWidgetLogicController
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

		public gameuiRandomNewsFeedAnimator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
