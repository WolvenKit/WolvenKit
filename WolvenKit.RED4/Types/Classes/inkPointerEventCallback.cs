
namespace WolvenKit.RED4.Types
{
	public partial class inkPointerEventCallback : inkCallbackBase
	{
		public inkPointerEventCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
