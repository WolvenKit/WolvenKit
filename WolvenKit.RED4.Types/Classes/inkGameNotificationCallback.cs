
namespace WolvenKit.RED4.Types
{
	public partial class inkGameNotificationCallback : inkCallbackBase
	{
		public inkGameNotificationCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
