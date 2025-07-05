
namespace WolvenKit.RED4.Types
{
	public partial class inkEmptyCallback : inkCallbackBase
	{
		public inkEmptyCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
