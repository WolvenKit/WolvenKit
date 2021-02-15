using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questAudioEventPrefetchNode : questIAudioNodeType
	{
		[Ordinal(0)] [RED("prefetchEvents")] public CArray<questAudioEventPrefetchStruct> PrefetchEvents { get; set; }

		public questAudioEventPrefetchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
