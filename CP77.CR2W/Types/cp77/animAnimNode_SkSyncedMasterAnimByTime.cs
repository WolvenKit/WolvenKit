using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSyncedMasterAnimByTime : animAnimNode_SkFrameAnim
	{
		[Ordinal(34)] [RED("syncTag")] public CName SyncTag { get; set; }

		public animAnimNode_SkSyncedMasterAnimByTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
