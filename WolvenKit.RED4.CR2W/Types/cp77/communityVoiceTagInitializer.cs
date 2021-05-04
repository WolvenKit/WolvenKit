using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityVoiceTagInitializer : communitySpawnInitializer
	{
		private CName _voiceTagName;

		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get => GetProperty(ref _voiceTagName);
			set => SetProperty(ref _voiceTagName, value);
		}

		public communityVoiceTagInitializer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
