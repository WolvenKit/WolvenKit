using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsStopSound : redEvent
	{
		private CName _soundName;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetProperty(ref _soundName);
			set => SetProperty(ref _soundName, value);
		}

		public gameaudioeventsStopSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
