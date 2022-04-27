
namespace WolvenKit.RED4.Types
{
	public partial class inkLoadingFadeInOutCallback : inkCallbackBase
	{
		public inkLoadingFadeInOutCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
