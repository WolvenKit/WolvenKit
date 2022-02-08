
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSettingChangeCallback : inkCallbackBase
	{

		public inkSettingChangeCallback()
		{
			CallbackName = "";
			Listeners = new();
		}
	}
}
