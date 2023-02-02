
namespace WolvenKit.RED4.Types
{
	public partial class inkHyperlinkCallback : inkCallbackBase
	{
		public inkHyperlinkCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
