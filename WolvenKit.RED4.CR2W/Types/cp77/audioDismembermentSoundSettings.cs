using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDismembermentSoundSettings : audioAudioMetadata
	{
		private CName _headEvent;
		private CName _armEvent;
		private CName _legEvent;

		[Ordinal(1)] 
		[RED("headEvent")] 
		public CName HeadEvent
		{
			get => GetProperty(ref _headEvent);
			set => SetProperty(ref _headEvent, value);
		}

		[Ordinal(2)] 
		[RED("armEvent")] 
		public CName ArmEvent
		{
			get => GetProperty(ref _armEvent);
			set => SetProperty(ref _armEvent, value);
		}

		[Ordinal(3)] 
		[RED("legEvent")] 
		public CName LegEvent
		{
			get => GetProperty(ref _legEvent);
			set => SetProperty(ref _legEvent, value);
		}

		public audioDismembermentSoundSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
