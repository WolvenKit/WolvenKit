
namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_PrefetchEntityAppearance : questCharacterManagerVisuals_EntityAppearanceOperationBase
	{
		public questCharacterManagerVisuals_PrefetchEntityAppearance()
		{
			AppearanceEntries = new() { new questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry { PuppetRef = new gameEntityReference { Names = new() } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
