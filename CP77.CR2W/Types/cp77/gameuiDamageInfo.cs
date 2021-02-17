using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageInfo : CVariable
	{
		[Ordinal(0)] [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(1)] [RED("damageValue")] public CFloat DamageValue { get; set; }
		[Ordinal(2)] [RED("damageType")] public CEnum<gamedataDamageType> DamageType { get; set; }
		[Ordinal(3)] [RED("hitType")] public CEnum<gameuiHitType> HitType { get; set; }
		[Ordinal(4)] [RED("entityHit")] public wCHandle<gameObject> EntityHit { get; set; }
		[Ordinal(5)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(6)] [RED("userData")] public CHandle<gameuiDamageInfoUserData> UserData { get; set; }

		public gameuiDamageInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
