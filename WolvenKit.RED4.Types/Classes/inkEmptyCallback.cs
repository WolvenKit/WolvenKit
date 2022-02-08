
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkEmptyCallback : inkCallbackBase
	{

		public inkEmptyCallback()
		{
			CallbackName = "";
			Listeners = new();
		}
	}
}
