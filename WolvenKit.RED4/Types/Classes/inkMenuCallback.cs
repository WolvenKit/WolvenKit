
namespace WolvenKit.RED4.Types
{
	public partial class inkMenuCallback : inkCallbackBase
	{
		public inkMenuCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
