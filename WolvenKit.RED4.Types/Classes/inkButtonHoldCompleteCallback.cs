
namespace WolvenKit.RED4.Types
{
	public partial class inkButtonHoldCompleteCallback : inkCallbackBase
	{
		public inkButtonHoldCompleteCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
