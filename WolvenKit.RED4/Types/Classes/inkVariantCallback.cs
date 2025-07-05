
namespace WolvenKit.RED4.Types
{
	public partial class inkVariantCallback : inkCallbackBase
	{
		public inkVariantCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
