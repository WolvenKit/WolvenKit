using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("onCollisionAction")] 
		public CEnum<gameprojectileOnCollisionAction> OnCollisionAction
		{
			get => GetPropertyValue<CEnum<gameprojectileOnCollisionAction>>();
			set => SetPropertyValue<CEnum<gameprojectileOnCollisionAction>>(value);
		}

		[Ordinal(6)] 
		[RED("useSweepCollision")] 
		public CBool UseSweepCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("collisionsFilterClosest")] 
		public CBool CollisionsFilterClosest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("sweepCollisionRadius")] 
		public CFloat SweepCollisionRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(10)] 
		[RED("deriveOwnerVelocity")] 
		public CBool DeriveOwnerVelocity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("derivedVelocityParams")] 
		public gameprojectileVelocityParams DerivedVelocityParams
		{
			get => GetPropertyValue<gameprojectileVelocityParams>();
			set => SetPropertyValue<gameprojectileVelocityParams>(value);
		}

		[Ordinal(12)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(13)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetPropertyValue<physicsQueryPreset>();
			set => SetPropertyValue<physicsQueryPreset>(value);
		}

		[Ordinal(14)] 
		[RED("previewEffect")] 
		public CResourceAsyncReference<worldEffect> PreviewEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(15)] 
		[RED("bouncePreviewEffect")] 
		public CResourceAsyncReference<worldEffect> BouncePreviewEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(16)] 
		[RED("explosionPreviewEffect")] 
		public CResourceAsyncReference<worldEffect> ExplosionPreviewEffect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(17)] 
		[RED("explosionPreviewTime")] 
		public CFloat ExplosionPreviewTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		public gameprojectileComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			OnCollisionAction = Enums.gameprojectileOnCollisionAction.Stop;
			CollisionsFilterClosest = true;
			RotationOffset = new() { R = 1.000000F };
			DeriveOwnerVelocity = true;
			DerivedVelocityParams = new() { XFactor = 1.000000F, YFactor = 1.000000F, ZFactor = 1.000000F };
			QueryPreset = new();
			GameEffectRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
