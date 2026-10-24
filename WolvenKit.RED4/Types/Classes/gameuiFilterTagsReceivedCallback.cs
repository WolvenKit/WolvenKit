
namespace WolvenKit.RED4.Types
{
	public partial class gameuiFilterTagsReceivedCallback : inkCallbackBase
	{
		public gameuiFilterTagsReceivedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
