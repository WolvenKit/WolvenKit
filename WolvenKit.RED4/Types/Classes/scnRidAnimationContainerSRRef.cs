using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidAnimationContainerSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnRidAnimationContainerSRRefAnimContainer> Animations
		{
			get => GetPropertyValue<CArray<scnRidAnimationContainerSRRefAnimContainer>>();
			set => SetPropertyValue<CArray<scnRidAnimationContainerSRRefAnimContainer>>(value);
		}

		public scnRidAnimationContainerSRRef()
		{
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
