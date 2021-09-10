
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerVisuals_PrefetchEntityAppearance : questCharacterManagerVisuals_EntityAppearanceOperationBase
	{

		public questCharacterManagerVisuals_PrefetchEntityAppearance()
		{
			AppearanceEntries = new() { new() { PuppetRef = new() { Names = new() } } };
		}
	}
}
