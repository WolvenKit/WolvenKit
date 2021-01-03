using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CentaurShieldController : AICustomComponents
	{
		[Ordinal(0)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(1)]  [RED("centaurBlackboard")] public CHandle<gameIBlackboard> CentaurBlackboard { get; set; }
		[Ordinal(2)]  [RED("explosionAttack")] public gameEffectRef ExplosionAttack { get; set; }
		[Ordinal(3)]  [RED("shieldDestroyedModifierName")] public CName ShieldDestroyedModifierName { get; set; }
		[Ordinal(4)]  [RED("shieldState")] public CEnum<ECentaurShieldState> ShieldState { get; set; }
		[Ordinal(5)]  [RED("startWithShieldActive")] public CBool StartWithShieldActive { get; set; }

		public CentaurShieldController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
