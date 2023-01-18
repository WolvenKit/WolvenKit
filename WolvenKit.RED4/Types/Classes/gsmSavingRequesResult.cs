
namespace WolvenKit.RED4.Types
{
	public partial class gsmSavingRequesResult : inkCallbackBase
	{
		public gsmSavingRequesResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
