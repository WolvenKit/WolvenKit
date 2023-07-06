using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttackDebugData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pointOfViewTransform")] 
		public WorldTransform PointOfViewTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(1)] 
		[RED("projectileHitplaneSpread")] 
		public Vector4 ProjectileHitplaneSpread
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("bulletStartPosition")] 
		public Vector4 BulletStartPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameAttackDebugData()
		{
			PointOfViewTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			ProjectileHitplaneSpread = new Vector4();
			BulletStartPosition = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
