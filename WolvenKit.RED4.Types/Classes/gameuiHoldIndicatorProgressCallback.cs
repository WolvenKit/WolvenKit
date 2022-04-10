
namespace WolvenKit.RED4.Types
{
	public partial class gameuiHoldIndicatorProgressCallback : inkCallbackBase
	{
		public gameuiHoldIndicatorProgressCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
