
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPointerEventCallback : inkCallbackBase
	{

		public inkPointerEventCallback()
		{
			CallbackName = "";
			Listeners = new();
		}
	}
}
