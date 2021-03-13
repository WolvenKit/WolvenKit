using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksSkillsLevelDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("tint")] public inkWidgetReference Tint { get; set; }

		public PerksSkillsLevelDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
