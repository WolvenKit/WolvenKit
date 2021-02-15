using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapData : IScriptable
	{
		[Ordinal(0)] [RED("action")] public CEnum<gamedataWorkspotActionType> Action { get; set; }
		[Ordinal(1)] [RED("workspots")] public CArray<CHandle<WorkspotEntryData>> Workspots { get; set; }

		public WorkspotMapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
