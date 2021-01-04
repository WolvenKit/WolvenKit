using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileShootEvent : gameprojectileSetUpEvent
	{
		[Ordinal(0)]  [RED("localToWorld")] public CMatrix LocalToWorld { get; set; }
		[Ordinal(1)]  [RED("params")] public gameprojectileWeaponParams Params { get; set; }
		[Ordinal(2)]  [RED("startPoint")] public Vector4 StartPoint { get; set; }
		[Ordinal(3)]  [RED("startVelocity")] public Vector4 StartVelocity { get; set; }
		[Ordinal(4)]  [RED("weaponVelocity")] public Vector4 WeaponVelocity { get; set; }

		public gameprojectileShootEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
