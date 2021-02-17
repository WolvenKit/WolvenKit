using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileShootEvent : gameprojectileSetUpEvent
	{
		[Ordinal(4)] [RED("localToWorld")] public Matrix LocalToWorld { get; set; }
		[Ordinal(5)] [RED("startPoint")] public Vector4 StartPoint { get; set; }
		[Ordinal(6)] [RED("startVelocity")] public Vector4 StartVelocity { get; set; }
		[Ordinal(7)] [RED("weaponVelocity")] public Vector4 WeaponVelocity { get; set; }
		[Ordinal(8)] [RED("params")] public gameprojectileWeaponParams Params { get; set; }

		public gameprojectileShootEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
