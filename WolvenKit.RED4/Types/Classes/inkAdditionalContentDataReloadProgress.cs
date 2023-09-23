
namespace WolvenKit.RED4.Types
{
	public partial class inkAdditionalContentDataReloadProgress : inkCallbackBase
	{
		public inkAdditionalContentDataReloadProgress()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
