using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BulletCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		[Ordinal(0)]  [RED("hasStopped")] public CBool HasStopped { get; set; }
		[Ordinal(1)]  [RED("isExplodingBullet")] public CBool IsExplodingBullet { get; set; }
		[Ordinal(2)]  [RED("stoppedPosition")] public Vector4 StoppedPosition { get; set; }
		[Ordinal(3)]  [RED("weaponParams")] public gameprojectileWeaponParams WeaponParams { get; set; }

		public BulletCollisionEvaluator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
