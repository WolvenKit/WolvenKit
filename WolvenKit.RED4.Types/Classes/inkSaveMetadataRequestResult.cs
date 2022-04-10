
namespace WolvenKit.RED4.Types
{
	public partial class inkSaveMetadataRequestResult : inkCallbackBase
	{
		public inkSaveMetadataRequestResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
