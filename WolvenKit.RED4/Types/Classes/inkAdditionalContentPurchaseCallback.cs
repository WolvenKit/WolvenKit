
namespace WolvenKit.RED4.Types
{
	public partial class inkAdditionalContentPurchaseCallback : inkCallbackBase
	{
		public inkAdditionalContentPurchaseCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
