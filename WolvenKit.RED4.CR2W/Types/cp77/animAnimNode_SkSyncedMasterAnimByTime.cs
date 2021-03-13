using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSyncedMasterAnimByTime : animAnimNode_SkFrameAnim
	{
		[Ordinal(34)] [RED("syncTag")] public CName SyncTag { get; set; }

		public animAnimNode_SkSyncedMasterAnimByTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
