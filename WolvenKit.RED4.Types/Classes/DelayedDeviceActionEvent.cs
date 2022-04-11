using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DelayedDeviceActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}
	}
}
