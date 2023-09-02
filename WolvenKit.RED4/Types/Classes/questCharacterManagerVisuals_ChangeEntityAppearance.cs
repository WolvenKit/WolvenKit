
namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerVisuals_ChangeEntityAppearance : questCharacterManagerVisuals_EntityAppearanceOperationBase
	{
		public questCharacterManagerVisuals_ChangeEntityAppearance()
		{
			AppearanceEntries = new() { new questCharacterManagerVisuals_EntityAppearanceOperationBaseEntityAppearanceEntry() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
