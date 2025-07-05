
namespace WolvenKit.RED4.Types
{
	public partial class servicesCloudSavesQueryStatusChangeCallback : inkCallbackBase
	{
		public servicesCloudSavesQueryStatusChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
