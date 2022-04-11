
namespace WolvenKit.RED4.Types
{
	public partial class inkSaveTransferRequestUpdate : inkCallbackBase
	{
		public inkSaveTransferRequestUpdate()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
