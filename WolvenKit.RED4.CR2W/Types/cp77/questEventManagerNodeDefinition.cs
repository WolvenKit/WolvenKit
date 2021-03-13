using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEventManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("isObjectPlayer")] public CBool IsObjectPlayer { get; set; }
		[Ordinal(3)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(4)] [RED("managerName")] public CString ManagerName { get; set; }
		[Ordinal(5)] [RED("event")] public CHandle<IScriptable> Event { get; set; }
		[Ordinal(6)] [RED("PSClassName")] public CName PSClassName { get; set; }
		[Ordinal(7)] [RED("componentName")] public CName ComponentName { get; set; }

		public questEventManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
