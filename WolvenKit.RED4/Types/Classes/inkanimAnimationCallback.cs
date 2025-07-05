
namespace WolvenKit.RED4.Types
{
	public partial class inkanimAnimationCallback : inkCallbackBase
	{
		public inkanimAnimationCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
