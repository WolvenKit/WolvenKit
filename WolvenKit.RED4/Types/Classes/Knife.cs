using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Knife : BaseProjectile
	{
		[Ordinal(46)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetPropertyValue<CHandle<ResourceLibraryComponent>>();
			set => SetPropertyValue<CHandle<ResourceLibraryComponent>>(value);
		}

		[Ordinal(47)] 
		[RED("throwCooldownSE")] 
		public TweakDBID ThrowCooldownSE
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(48)] 
		[RED("collided")] 
		public CBool Collided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("wasPicked")] 
		public CBool WasPicked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(50)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("hasHitWater")] 
		public CBool HasHitWater
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("deactivationDepth")] 
		public CFloat DeactivationDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("waterImpulseRadius")] 
		public CFloat WaterImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("waterImpulseStrength")] 
		public CFloat WaterImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(57)] 
		[RED("throwingKnifeResourcePoolListener")] 
		public CHandle<ThrowingKnifeReloadListener> ThrowingKnifeResourcePoolListener
		{
			get => GetPropertyValue<CHandle<ThrowingKnifeReloadListener>>();
			set => SetPropertyValue<CHandle<ThrowingKnifeReloadListener>>(value);
		}

		[Ordinal(58)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<KnifeCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<KnifeCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<KnifeCollisionEvaluator>>(value);
		}

		[Ordinal(59)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Knife()
		{
			ForceRegisterInHudManager = true;
			IsActive = true;
			DeactivationDepth = -99999.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
