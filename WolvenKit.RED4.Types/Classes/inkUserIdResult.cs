
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkUserIdResult : inkCallbackBase
	{

		public inkUserIdResult()
		{
			CallbackName = "UserIdResult";
			Listeners = new();
		}
	}
}
