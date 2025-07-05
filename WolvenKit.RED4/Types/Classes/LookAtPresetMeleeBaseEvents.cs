
namespace WolvenKit.RED4.Types
{
	public partial class LookAtPresetMeleeBaseEvents : LookAtPresetBaseEvents
	{
		public LookAtPresetMeleeBaseEvents()
		{
			LookAtEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
