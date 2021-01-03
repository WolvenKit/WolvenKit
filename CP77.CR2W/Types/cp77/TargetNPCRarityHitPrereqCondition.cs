using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TargetNPCRarityHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("rarity")] public CEnum<gamedataNPCRarity> Rarity { get; set; }

		public TargetNPCRarityHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
