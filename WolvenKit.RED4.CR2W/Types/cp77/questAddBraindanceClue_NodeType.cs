using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAddBraindanceClue_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("clueName")] public CName ClueName { get; set; }
		[Ordinal(1)] [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(2)] [RED("endTime")] public CFloat EndTime { get; set; }
		[Ordinal(3)] [RED("layer")] public CEnum<gameuiEBraindanceLayer> Layer { get; set; }

		public questAddBraindanceClue_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
