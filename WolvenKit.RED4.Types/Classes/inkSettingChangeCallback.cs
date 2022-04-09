
namespace WolvenKit.RED4.Types
{
	public partial class inkSettingChangeCallback : inkCallbackBase
	{
		public inkSettingChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
