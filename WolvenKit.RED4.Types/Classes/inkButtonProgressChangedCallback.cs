
namespace WolvenKit.RED4.Types
{
	public partial class inkButtonProgressChangedCallback : inkCallbackBase
	{
		public inkButtonProgressChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
