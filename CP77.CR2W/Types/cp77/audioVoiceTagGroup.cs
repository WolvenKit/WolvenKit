using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTagGroup : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("voiceTags")] public CArray<CName> VoiceTags { get; set; }

		public audioVoiceTagGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
