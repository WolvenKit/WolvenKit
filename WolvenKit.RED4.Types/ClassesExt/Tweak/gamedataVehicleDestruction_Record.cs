
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDestruction_Record
	{
		[RED("damageExponent")]
		[REDProperty(IsIgnored = true)]
		public CFloat DamageExponent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("damageThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat DamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("deformableParts")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> DeformableParts
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("detachableParts")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> DetachableParts
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("detachedPartExplosionEffect")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> DetachedPartExplosionEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("enableOnHit")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableOnHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forcePropagationFalloff")]
		[REDProperty(IsIgnored = true)]
		public CFloat ForcePropagationFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("glass")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Glass
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("gridDimensions")]
		[REDProperty(IsIgnored = true)]
		public Vector3 GridDimensions
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("gridLocalOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 GridLocalOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("lights")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Lights
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("onHitVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat OnHitVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pointDampers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PointDampers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("vehicleDimensions")]
		[REDProperty(IsIgnored = true)]
		public Vector3 VehicleDimensions
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("velocityValueMaxDamage")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityValueMaxDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("velocityValueMinDamage")]
		[REDProperty(IsIgnored = true)]
		public CFloat VelocityValueMinDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("wheels")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Wheels
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
