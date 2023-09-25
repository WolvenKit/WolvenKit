using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeProjectile : BaseProjectile
	{
		[Ordinal(48)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(49)] 
		[RED("throwCooldownSE")] 
		public TweakDBID ThrowCooldownSE
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(50)] 
		[RED("collided")] 
		public CBool Collided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("wasPicked")] 
		public CBool WasPicked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("hasHitWater")] 
		public CBool HasHitWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(54)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("deactivationDepth")] 
		public CFloat DeactivationDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("waterImpulseRadius")] 
		public CFloat WaterImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("waterImpulseStrength")] 
		public CFloat WaterImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("gravitySimulationMult")] 
		public CFloat GravitySimulationMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(60)] 
		[RED("throwingMeleeResourcePoolListener")] 
		public CHandle<ThrowingMeleeReloadListener> ThrowingMeleeResourcePoolListener
		{
			get => GetPropertyValue<CHandle<ThrowingMeleeReloadListener>>();
			set => SetPropertyValue<CHandle<ThrowingMeleeReloadListener>>(value);
		}

		[Ordinal(61)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ThrowingMeleeCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<ThrowingMeleeCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<ThrowingMeleeCollisionEvaluator>>(value);
		}

		[Ordinal(62)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("isCollidedWithEnemy")] 
		public CBool IsCollidedWithEnemy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeProjectile()
		{
			ForceRegisterInHudManager = true;
			IsActive = true;
			DeactivationDepth = -99999.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
