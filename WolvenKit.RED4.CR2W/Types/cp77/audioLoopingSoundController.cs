using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLoopingSoundController : CVariable
	{
		private CName _playEvent;
		private CName _preStopEvent;
		private CName _stopEvent;

		[Ordinal(0)] 
		[RED("playEvent")] 
		public CName PlayEvent
		{
			get => GetProperty(ref _playEvent);
			set => SetProperty(ref _playEvent, value);
		}

		[Ordinal(1)] 
		[RED("preStopEvent")] 
		public CName PreStopEvent
		{
			get => GetProperty(ref _preStopEvent);
			set => SetProperty(ref _preStopEvent, value);
		}

		[Ordinal(2)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetProperty(ref _stopEvent);
			set => SetProperty(ref _stopEvent, value);
		}

		public audioLoopingSoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
