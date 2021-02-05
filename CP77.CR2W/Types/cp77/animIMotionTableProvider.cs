using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animIMotionTableProvider : ISerializable
	{
		[Ordinal(0)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)]  [RED("parentId")] public CInt32 ParentId { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<animMotionTableType> Type { get; set; }
		[Ordinal(3)]  [RED("action")] public CEnum<animMotionTableAction> Action { get; set; }
		[Ordinal(4)]  [RED("parentStaticSwitchBranch")] public CEnum<animParentStaticSwitchBranch> ParentStaticSwitchBranch { get; set; }

		public animIMotionTableProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
