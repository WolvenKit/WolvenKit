using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateLock : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("enteringArea")] 
		public CHandle<gameStaticTriggerAreaComponent> EnteringArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("centeredArea")] 
		public CHandle<gameStaticTriggerAreaComponent> CenteredArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("leavingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> LeavingArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		public SecurityGateLock()
		{
			ControllerTypeName = "SecurityGateLockController";
		}
	}
}
