using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityTurretControllerPS : SensorDeviceControllerPS
	{
		[Ordinal(144)]  [RED("pendingSecuritySystemDisableRequest")] public CBool PendingSecuritySystemDisableRequest { get; set; }
		[Ordinal(145)]  [RED("turretSkillChecks")] public CHandle<EngDemoContainer> TurretSkillChecks { get; set; }
		[Ordinal(146)]  [RED("ignoreSkillcheckGeneration")] public CBool IgnoreSkillcheckGeneration { get; set; }
		[Ordinal(147)]  [RED("laserGameEffectRef")] public gameEffectRef LaserGameEffectRef { get; set; }
		[Ordinal(148)]  [RED("weaponItemRecordString")] public CString WeaponItemRecordString { get; set; }
		[Ordinal(149)]  [RED("vfxNameOnShoot")] public CName VfxNameOnShoot { get; set; }

		public SecurityTurretControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
