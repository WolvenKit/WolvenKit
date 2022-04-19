
namespace WolvenKit.RED4.Types
{
	public partial class inkAdvertisementsLayerDefinition : inkLayerDefinition
	{
		public inkAdvertisementsLayerDefinition()
		{
			ActiveByDefault = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
