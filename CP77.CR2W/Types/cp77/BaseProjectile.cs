using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseProjectile : gameItemObject
	{
		[Ordinal(33)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(34)]  [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(35)]  [RED("projectile")] public wCHandle<gameObject> Projectile { get; set; }
		[Ordinal(36)]  [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(37)]  [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(38)]  [RED("initialLaunchVelocity")] public CFloat InitialLaunchVelocity { get; set; }
		[Ordinal(39)]  [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(40)]  [RED("tweakDBPath")] public CString TweakDBPath { get; set; }

		public BaseProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
