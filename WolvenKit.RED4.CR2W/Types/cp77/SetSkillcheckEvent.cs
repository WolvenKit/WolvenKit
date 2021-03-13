using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetSkillcheckEvent : redEvent
	{
		[Ordinal(0)] [RED("skillcheckContainer")] public CHandle<BaseSkillCheckContainer> SkillcheckContainer { get; set; }

		public SetSkillcheckEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
