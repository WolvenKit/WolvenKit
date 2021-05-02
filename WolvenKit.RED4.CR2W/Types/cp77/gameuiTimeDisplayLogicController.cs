using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTimeDisplayLogicController : inkWidgetLogicController
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

		public gameuiTimeDisplayLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
