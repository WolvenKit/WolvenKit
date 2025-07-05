
namespace WolvenKit.RED4.Types
{
	public partial class inkTextCallback : inkCallbackBase
	{
		public inkTextCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
