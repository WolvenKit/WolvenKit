using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMusicController : CVariable
	{
		private CName _playEvent;
		private CName _stopEvent;
		private CName _muteEvent;
		private CName _unmuteEvent;

		[Ordinal(0)] 
		[RED("playEvent")] 
		public CName PlayEvent
		{
			get => GetProperty(ref _playEvent);
			set => SetProperty(ref _playEvent, value);
		}

		[Ordinal(1)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetProperty(ref _stopEvent);
			set => SetProperty(ref _stopEvent, value);
		}

		[Ordinal(2)] 
		[RED("muteEvent")] 
		public CName MuteEvent
		{
			get => GetProperty(ref _muteEvent);
			set => SetProperty(ref _muteEvent, value);
		}

		[Ordinal(3)] 
		[RED("unmuteEvent")] 
		public CName UnmuteEvent
		{
			get => GetProperty(ref _unmuteEvent);
			set => SetProperty(ref _unmuteEvent, value);
		}

		public audioMusicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
