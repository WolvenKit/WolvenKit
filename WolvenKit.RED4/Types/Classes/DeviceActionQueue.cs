using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceActionQueue : IScriptable
	{
		[Ordinal(0)] 
		[RED("actionsInQueue")] 
		public CArray<CHandle<gamedeviceAction>> ActionsInQueue
		{
			get => GetPropertyValue<CArray<CHandle<gamedeviceAction>>>();
			set => SetPropertyValue<CArray<CHandle<gamedeviceAction>>>(value);
		}

		[Ordinal(1)] 
		[RED("maxQueueSize")] 
		public CInt32 MaxQueueSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceActionQueue()
		{
			ActionsInQueue = new();
			MaxQueueSize = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
