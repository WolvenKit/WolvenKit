using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimatorComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("animations")] 
		public CArray<gameTransformAnimationDefinition> Animations
		{
			get => GetPropertyValue<CArray<gameTransformAnimationDefinition>>();
			set => SetPropertyValue<CArray<gameTransformAnimationDefinition>>(value);
		}

		public gameTransformAnimatorComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
