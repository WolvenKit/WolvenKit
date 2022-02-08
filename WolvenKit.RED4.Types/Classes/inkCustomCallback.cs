
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCustomCallback : inkCallbackBase
	{

		public inkCustomCallback()
		{
			CallbackName = "";
			Listeners = new();
		}
	}
}
