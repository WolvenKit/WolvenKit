using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSyncedMasterAnimByTime : animAnimNode_SkFrameAnim
	{
		[Ordinal(0)]  [RED("syncTag")] public CName SyncTag { get; set; }

		public animAnimNode_SkSyncedMasterAnimByTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
