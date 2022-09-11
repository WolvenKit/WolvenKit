
namespace WolvenKit.RED4.Types
{
	public partial class inkCloudSaveUploadFinish : inkCallbackBase
	{
		public inkCloudSaveUploadFinish()
		{
			CallbackName = "CloudSaveUploadFinish";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
