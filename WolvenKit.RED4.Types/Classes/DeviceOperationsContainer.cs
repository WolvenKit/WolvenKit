using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceOperationsContainer : IScriptable
	{
		private CArray<CHandle<DeviceOperationBase>> _operations;
		private CArray<CHandle<DeviceOperationsTrigger>> _triggers;

		[Ordinal(0)] 
		[RED("operations")] 
		public CArray<CHandle<DeviceOperationBase>> Operations
		{
			get => GetProperty(ref _operations);
			set => SetProperty(ref _operations, value);
		}

		[Ordinal(1)] 
		[RED("triggers")] 
		public CArray<CHandle<DeviceOperationsTrigger>> Triggers
		{
			get => GetProperty(ref _triggers);
			set => SetProperty(ref _triggers, value);
		}
	}
}
