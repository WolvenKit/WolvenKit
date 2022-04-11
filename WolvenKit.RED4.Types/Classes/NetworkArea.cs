using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkArea : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("area")] 
		public CHandle<gameStaticTriggerAreaComponent> Area
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		public NetworkArea()
		{
			ControllerTypeName = "NetworkAreaController";
		}
	}
}
