using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questAudioEventPrefetchNode : questIAudioNodeType
	{
		[Ordinal(0)]  [RED("prefetchEvents")] public CArray<questAudioEventPrefetchStruct> PrefetchEvents { get; set; }

		public questAudioEventPrefetchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
