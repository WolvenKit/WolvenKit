
namespace WolvenKit.RED4.Types
{
	public partial class servicesCloudSaveUploadFinishCallback : inkCallbackBase
	{
		public servicesCloudSaveUploadFinishCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
