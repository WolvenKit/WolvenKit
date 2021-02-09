using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldController : AICustomComponents
	{
		[Ordinal(0)]  [RED("startWithShieldActive")] public CBool StartWithShieldActive { get; set; }
		[Ordinal(1)]  [RED("explosionAttack")] public gameEffectRef ExplosionAttack { get; set; }
		[Ordinal(2)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(3)]  [RED("shieldDestroyedModifierName")] public CName ShieldDestroyedModifierName { get; set; }
		[Ordinal(4)]  [RED("shieldState")] public CEnum<ECentaurShieldState> ShieldState { get; set; }
		[Ordinal(5)]  [RED("centaurBlackboard")] public CHandle<gameIBlackboard> CentaurBlackboard { get; set; }

		public CentaurShieldController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
