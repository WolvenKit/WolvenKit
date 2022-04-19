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
			PointOfViewTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			ProjectileHitplaneSpread = new();
			BulletStartPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
