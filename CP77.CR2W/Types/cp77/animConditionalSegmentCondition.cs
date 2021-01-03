using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animConditionalSegmentCondition : CVariable
	{
		[Ordinal(0)]  [RED("animFeatureValue")] public CBool AnimFeatureValue { get; set; }
		[Ordinal(1)]  [RED("group")] public CName Group { get; set; }
		[Ordinal(2)]  [RED("lod")] public CInt32 Lod { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }

		public animConditionalSegmentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
