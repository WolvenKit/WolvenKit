
namespace WolvenKit.RED4.Types
{
	public partial class lookAtPresetItemBaseEvents : LookAtPresetBaseEvents
	{
		public lookAtPresetItemBaseEvents()
		{
			LookAtEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
