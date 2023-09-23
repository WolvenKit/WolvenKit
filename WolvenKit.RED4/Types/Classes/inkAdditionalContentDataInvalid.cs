
namespace WolvenKit.RED4.Types
{
	public partial class inkAdditionalContentDataInvalid : inkCallbackBase
	{
		public inkAdditionalContentDataInvalid()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
