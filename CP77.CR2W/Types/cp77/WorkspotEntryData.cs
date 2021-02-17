using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorkspotEntryData : IScriptable
	{
		[Ordinal(0)] [RED("workspotRef")] public NodeRef WorkspotRef { get; set; }
		[Ordinal(1)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)] [RED("isAvailable")] public CBool IsAvailable { get; set; }

		public WorkspotEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
