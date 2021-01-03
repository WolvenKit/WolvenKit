using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckFreeWorkspot : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("AIAction")] public CEnum<gamedataWorkspotActionType> AIAction { get; set; }
		[Ordinal(1)]  [RED("globalRef")] public worldGlobalNodeRef GlobalRef { get; set; }
		[Ordinal(2)]  [RED("workspotData")] public CHandle<WorkspotEntryData> WorkspotData { get; set; }
		[Ordinal(3)]  [RED("workspotObject")] public wCHandle<gameObject> WorkspotObject { get; set; }

		public CheckFreeWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
