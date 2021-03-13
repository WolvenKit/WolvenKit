using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseProjectile : gameItemObject
	{
		[Ordinal(43)] [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(44)] [RED("user")] public wCHandle<gameObject> User { get; set; }
		[Ordinal(45)] [RED("projectile")] public wCHandle<gameObject> Projectile { get; set; }
		[Ordinal(46)] [RED("projectileSpawnPoint")] public Vector4 ProjectileSpawnPoint { get; set; }
		[Ordinal(47)] [RED("projectilePosition")] public Vector4 ProjectilePosition { get; set; }
		[Ordinal(48)] [RED("initialLaunchVelocity")] public CFloat InitialLaunchVelocity { get; set; }
		[Ordinal(49)] [RED("lifeTime")] public CFloat LifeTime { get; set; }
		[Ordinal(50)] [RED("tweakDBPath")] public CString TweakDBPath { get; set; }

		public BaseProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
