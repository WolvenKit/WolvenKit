using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LifePath_ScriptConditionType : BluelineConditionTypeBase
	{
		[Ordinal(0)] [RED("lifePathId")] public TweakDBID LifePathId { get; set; }
		[Ordinal(1)] [RED("inverted")] public CBool Inverted { get; set; }

		public LifePath_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
