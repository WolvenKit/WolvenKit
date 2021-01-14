using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseProjectile : gameItemObject
	{
		[Ordinal(0)]  [RED("initialLaunchVelocity")] public CFloat InitialLaunchVelocity { get; set; }
		[Ordinal(1)]  [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(2)]  [RED("projectile")] public wCHandle<gameObject> Projectile { get; set; }
		[Ordinal(3)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(4)]  [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(5)]  [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(6)]  [RED("tweakDBPath")] public CString TweakDBPath { get; set; }
		[Ordinal(7)]  [RED("user")] public wCHandle<gameObject> User { get; set; }

		public BaseProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
