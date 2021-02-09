using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_ActiveWeaponDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("WeaponRecordID")] public gamebbScriptID_Variant WeaponRecordID { get; set; }
		[Ordinal(1)]  [RED("BulletSpread")] public gamebbScriptID_Vector2 BulletSpread { get; set; }
		[Ordinal(2)]  [RED("SmartGunParams")] public gamebbScriptID_Variant SmartGunParams { get; set; }
		[Ordinal(3)]  [RED("TargetHitEvent")] public gamebbScriptID_Variant TargetHitEvent { get; set; }
		[Ordinal(4)]  [RED("ShootEvent")] public gamebbScriptID_Variant ShootEvent { get; set; }

		public UI_ActiveWeaponDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
