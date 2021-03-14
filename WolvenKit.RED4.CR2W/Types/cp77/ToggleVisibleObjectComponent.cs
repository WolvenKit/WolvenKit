using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleVisibleObjectComponent : StatusEffectTasks
	{
		[Ordinal(0)] [RED("componentTargetState")] public CBool ComponentTargetState { get; set; }
		[Ordinal(1)] [RED("visibleObjectDescription")] public CName VisibleObjectDescription { get; set; }

		public ToggleVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
