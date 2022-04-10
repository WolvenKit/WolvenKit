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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
