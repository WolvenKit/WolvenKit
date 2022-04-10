
namespace WolvenKit.RED4.Types
{
	public partial class gameuiMoveTargetCallback : inkCallbackBase
	{
		public gameuiMoveTargetCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
