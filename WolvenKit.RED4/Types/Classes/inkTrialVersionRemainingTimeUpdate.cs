
namespace WolvenKit.RED4.Types
{
	public partial class inkTrialVersionRemainingTimeUpdate : inkCallbackBase
	{
		public inkTrialVersionRemainingTimeUpdate()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
