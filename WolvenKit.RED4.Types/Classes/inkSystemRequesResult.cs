
namespace WolvenKit.RED4.Types
{
	public partial class inkSystemRequesResult : inkCallbackBase
	{
		public inkSystemRequesResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
