
namespace WolvenKit.RED4.Types
{
	public partial class inkFavoriteLoadResult : inkCallbackBase
	{
		public inkFavoriteLoadResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
