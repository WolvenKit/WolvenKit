using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityTurretControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(0)]  [RED("ignoreSkillcheckGeneration")] public CBool IgnoreSkillcheckGeneration { get; set; }
		[Ordinal(1)]  [RED("laserGameEffectRef")] public gameEffectRef LaserGameEffectRef { get; set; }
		[Ordinal(2)]  [RED("pendingSecuritySystemDisableRequest")] public CBool PendingSecuritySystemDisableRequest { get; set; }
		[Ordinal(3)]  [RED("turretSkillChecks")] public CHandle<EngDemoContainer> TurretSkillChecks { get; set; }
		[Ordinal(4)]  [RED("vfxNameOnShoot")] public CName VfxNameOnShoot { get; set; }
		[Ordinal(5)]  [RED("weaponItemRecordString")] public CString WeaponItemRecordString { get; set; }

		public SecurityTurretControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
