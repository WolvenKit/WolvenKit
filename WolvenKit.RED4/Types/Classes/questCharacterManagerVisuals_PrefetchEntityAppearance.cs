
namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_PrefetchEntityAppearance : questCharacterManagerVisuals_EntityAppearanceOperationBase
	{
		public questCharacterManagerVisuals_PrefetchEntityAppearance()
		{
			AppearanceEntries = new() { new questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
