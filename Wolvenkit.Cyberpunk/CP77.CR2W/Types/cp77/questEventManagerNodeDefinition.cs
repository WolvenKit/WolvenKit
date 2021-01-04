using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEventManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("PSClassName")] public CName PSClassName { get; set; }
		[Ordinal(1)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)]  [RED("event")] public CHandle<IScriptable> Event { get; set; }
		[Ordinal(3)]  [RED("isObjectPlayer")] public CBool IsObjectPlayer { get; set; }
		[Ordinal(4)]  [RED("managerName")] public CString ManagerName { get; set; }
		[Ordinal(5)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questEventManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
