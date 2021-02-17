using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_Kill : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("noAnimation")] public CBool NoAnimation { get; set; }
		[Ordinal(3)] [RED("noRagdoll")] public CBool NoRagdoll { get; set; }
		[Ordinal(4)] [RED("skipDefeatedState")] public CBool SkipDefeatedState { get; set; }
		[Ordinal(5)] [RED("doDismemberment")] public CBool DoDismemberment { get; set; }
		[Ordinal(6)] [RED("bodyPart")] public CEnum<physicsRagdollBodyPartE> BodyPart { get; set; }
		[Ordinal(7)] [RED("woundType")] public CEnum<entdismembermentWoundTypeE> WoundType { get; set; }
		[Ordinal(8)] [RED("dismembermentStrenght")] public CFloat DismembermentStrenght { get; set; }

		public questCharacterManagerCombat_Kill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
