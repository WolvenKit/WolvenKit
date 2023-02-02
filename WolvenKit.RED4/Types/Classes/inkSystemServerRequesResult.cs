
namespace WolvenKit.RED4.Types
{
	public partial class inkSystemServerRequesResult : inkCallbackBase
	{
		public inkSystemServerRequesResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
