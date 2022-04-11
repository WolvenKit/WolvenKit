
namespace WolvenKit.RED4.Types
{
	public partial class inkDeleteRequestResult : inkCallbackBase
	{
		public inkDeleteRequestResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
