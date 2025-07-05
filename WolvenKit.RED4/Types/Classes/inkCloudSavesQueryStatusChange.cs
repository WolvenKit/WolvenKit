
namespace WolvenKit.RED4.Types
{
	public partial class inkCloudSavesQueryStatusChange : inkCallbackBase
	{
		public inkCloudSavesQueryStatusChange()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
