
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGameNotificationCallback : inkCallbackBase
	{

		public inkGameNotificationCallback()
		{
			CallbackName = "";
			Listeners = new();
		}
	}
}
