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
			LocalTransform = new WorldTransform();
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
