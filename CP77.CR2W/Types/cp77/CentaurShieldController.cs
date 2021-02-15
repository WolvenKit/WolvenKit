using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldController : AICustomComponents
	{
		[Ordinal(5)] [RED("startWithShieldActive")] public CBool StartWithShieldActive { get; set; }
		[Ordinal(6)] [RED("explosionAttack")] public gameEffectRef ExplosionAttack { get; set; }
		[Ordinal(7)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(8)] [RED("shieldDestroyedModifierName")] public CName ShieldDestroyedModifierName { get; set; }
		[Ordinal(9)] [RED("shieldState")] public CEnum<ECentaurShieldState> ShieldState { get; set; }
		[Ordinal(10)] [RED("centaurBlackboard")] public CHandle<gameIBlackboard> CentaurBlackboard { get; set; }

		public CentaurShieldController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
