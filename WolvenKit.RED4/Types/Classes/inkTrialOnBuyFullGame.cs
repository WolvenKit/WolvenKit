
namespace WolvenKit.RED4.Types
{
	public partial class inkTrialOnBuyFullGame : inkCallbackBase
	{
		public inkTrialOnBuyFullGame()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
