
namespace WolvenKit.RED4.Types
{
	public partial class inkAdditionalContentInstallRequestedCallback : inkCallbackBase
	{
		public inkAdditionalContentInstallRequestedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
