using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleVisibleObjectComponent : StatusEffectTasks
	{
		[Ordinal(0)] [RED("componentTargetState")] public CBool ComponentTargetState { get; set; }
		[Ordinal(1)] [RED("visibleObjectDescription")] public CName VisibleObjectDescription { get; set; }

		public ToggleVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
