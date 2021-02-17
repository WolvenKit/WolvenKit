using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAudioMixNodeType : questIAudioNodeType
	{
		[Ordinal(0)] [RED("mixSignpost")] public CName MixSignpost { get; set; }

		public questAudioMixNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
