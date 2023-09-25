
namespace WolvenKit.RED4.Types
{
	public partial class UnarmedLookAtEvents : LookAtPresetBaseEvents
	{
		public UnarmedLookAtEvents()
		{
			LookAtEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
