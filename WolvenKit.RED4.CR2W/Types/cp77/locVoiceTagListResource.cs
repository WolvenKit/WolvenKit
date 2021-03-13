using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoiceTagListResource : CResource
	{
		[Ordinal(1)] [RED("voiceTags")] public CArray<locVoiceTag> VoiceTags { get; set; }

		public locVoiceTagListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
