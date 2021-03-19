using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMapItem : audioAudioMetadata
	{
		private CName _enterEvent;
		private CName _exitEvent;
		private CName _timeModeRTPC;

		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get => GetProperty(ref _enterEvent);
			set => SetProperty(ref _enterEvent, value);
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get => GetProperty(ref _exitEvent);
			set => SetProperty(ref _exitEvent, value);
		}

		[Ordinal(3)] 
		[RED("timeModeRTPC")] 
		public CName TimeModeRTPC
		{
			get => GetProperty(ref _timeModeRTPC);
			set => SetProperty(ref _timeModeRTPC, value);
		}

		public audioAudBulletTimeModeMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
