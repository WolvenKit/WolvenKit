
namespace WolvenKit.RED4.Types
{
	public partial class inkUserIdResult : inkCallbackBase
	{
		public inkUserIdResult()
		{
			CallbackName = "UserIdResult";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
