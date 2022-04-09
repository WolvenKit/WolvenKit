using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry()
		{
			PuppetRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
