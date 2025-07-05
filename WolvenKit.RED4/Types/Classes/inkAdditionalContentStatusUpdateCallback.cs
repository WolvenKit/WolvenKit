
namespace WolvenKit.RED4.Types
{
	public partial class inkAdditionalContentStatusUpdateCallback : inkCallbackBase
	{
		public inkAdditionalContentStatusUpdateCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
