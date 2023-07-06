using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimationSetupExtensionComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetPropertyValue<animAnimSetup>();
			set => SetPropertyValue<animAnimSetup>(value);
		}

		[Ordinal(4)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get => GetPropertyValue<CHandle<entAnimationControlBinding>>();
			set => SetPropertyValue<CHandle<entAnimationControlBinding>>(value);
		}

		public entAnimationSetupExtensionComponent()
		{
			Name = "Component";
			Animations = new animAnimSetup { Cinematics = new(), Gameplay = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
