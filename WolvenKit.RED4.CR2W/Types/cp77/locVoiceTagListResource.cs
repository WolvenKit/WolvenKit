using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoiceTagListResource : CResource
	{
		private CArray<locVoiceTag> _voiceTags;

		[Ordinal(1)] 
		[RED("voiceTags")] 
		public CArray<locVoiceTag> VoiceTags
		{
			get => GetProperty(ref _voiceTags);
			set => SetProperty(ref _voiceTags, value);
		}

		public locVoiceTagListResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
