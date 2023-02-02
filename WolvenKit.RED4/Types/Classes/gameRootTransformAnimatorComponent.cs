using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRootTransformAnimatorComponent : entIMoverComponent
	{
		[Ordinal(3)] 
		[RED("animations")] 
		public CArray<gameTransformAnimationDefinition> Animations
		{
			get => GetPropertyValue<CArray<gameTransformAnimationDefinition>>();
			set => SetPropertyValue<CArray<gameTransformAnimationDefinition>>(value);
		}

		public gameRootTransformAnimatorComponent()
		{
			Name = "Component";
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
