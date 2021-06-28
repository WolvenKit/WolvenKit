using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlaySoundEvent : MusicSettings
	{
		private CName _soundEvent;

		[Ordinal(1)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetProperty(ref _soundEvent);
			set => SetProperty(ref _soundEvent, value);
		}

		public PlaySoundEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
