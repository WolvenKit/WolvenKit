using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSyncedSlaveAnim : animAnimNode_SkAnim
	{
		[Ordinal(18)] [RED("syncTag")] public CName SyncTag { get; set; }

		public animAnimNode_SkSyncedSlaveAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
