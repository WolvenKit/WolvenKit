
namespace WolvenKit.RED4.Types
{
	public partial class inkGogSignInCallback : inkCallbackBase
	{
		public inkGogSignInCallback()
		{
			CallbackName = "GogSignInCallback";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
