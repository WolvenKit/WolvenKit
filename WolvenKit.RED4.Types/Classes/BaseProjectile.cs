using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseProjectile : gameItemObject
	{
		[Ordinal(43)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("user")] 
		public CWeakHandle<gameObject> User
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(45)] 
		[RED("projectile")] 
		public CWeakHandle<gameObject> Projectile
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(46)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(47)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(48)] 
		[RED("initialLaunchVelocity")] 
		public CFloat InitialLaunchVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("tweakDBPath")] 
		public CString TweakDBPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public BaseProjectile()
		{
			ProjectileSpawnPoint = new();
			ProjectilePosition = new();
		}
	}
}
