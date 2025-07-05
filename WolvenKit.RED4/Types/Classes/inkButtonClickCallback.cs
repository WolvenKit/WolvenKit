
namespace WolvenKit.RED4.Types
{
	public partial class inkButtonClickCallback : inkCallbackBase
	{
		public inkButtonClickCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
