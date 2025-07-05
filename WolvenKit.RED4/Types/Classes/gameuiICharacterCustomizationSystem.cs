using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiICharacterCustomizationSystem : gameIGameSystem
	{
		[Ordinal(0)] 
		[RED("puppetPreviewGameController")] 
		public CWeakHandle<gameuiCharacterCreationPuppetPreviewGameController> PuppetPreviewGameController
		{
			get => GetPropertyValue<CWeakHandle<gameuiCharacterCreationPuppetPreviewGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiCharacterCreationPuppetPreviewGameController>>(value);
		}

		public gameuiICharacterCustomizationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
