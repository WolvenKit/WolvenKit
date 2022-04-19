
namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_PrefetchEntityAppearance : questCharacterManagerVisuals_EntityAppearanceOperationBase
	{
		public questCharacterManagerVisuals_PrefetchEntityAppearance()
		{
			AppearanceEntries = new() { new() { PuppetRef = new() { Names = new() } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
