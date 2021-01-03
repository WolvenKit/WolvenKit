using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSceneTier_ConditionType : questISceneConditionType
	{
		[Ordinal(0)]  [RED("isInverted")] public CBool IsInverted { get; set; }
		[Ordinal(1)]  [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }

		public questSceneTier_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
