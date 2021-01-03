using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ParentTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("mapping")] public CArray<animAnimTransformMappingEntry> Mapping { get; set; }

		public animAnimNode_ParentTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
