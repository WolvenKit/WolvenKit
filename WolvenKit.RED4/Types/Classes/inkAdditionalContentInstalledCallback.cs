
namespace WolvenKit.RED4.Types
{
	public partial class inkAdditionalContentInstalledCallback : inkCallbackBase
	{
		public inkAdditionalContentInstalledCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
