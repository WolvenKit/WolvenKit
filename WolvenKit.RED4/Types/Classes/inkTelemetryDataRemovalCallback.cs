
namespace WolvenKit.RED4.Types
{
	public partial class inkTelemetryDataRemovalCallback : inkCallbackBase
	{
		public inkTelemetryDataRemovalCallback()
		{
			CallbackName = "TelemetryDataRemovalCallback";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
