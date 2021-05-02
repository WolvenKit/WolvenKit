using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeyboardHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		private inkImageWidgetReference _progress;

		[Ordinal(6)] 
		[RED("progress")] 
		public inkImageWidgetReference Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		public KeyboardHoldIndicatorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
