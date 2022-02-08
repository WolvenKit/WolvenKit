
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCharacterEventCallback : inkCallbackBase
	{

		public inkCharacterEventCallback()
		{
			CallbackName = "";
			Listeners = new();
		}
	}
}
