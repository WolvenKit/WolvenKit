
namespace WolvenKit.RED4.Types
{
	public partial class inkInputDeviceIdCallback : inkCallbackBase
	{
		public inkInputDeviceIdCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
