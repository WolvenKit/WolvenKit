using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericDevice : InteractiveDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CHandle<CustomDeviceAction> _currentSpiderbotAction;

		[Ordinal(97)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetProperty(ref _offMeshConnectionComponent);
			set => SetProperty(ref _offMeshConnectionComponent, value);
		}

		[Ordinal(98)] 
		[RED("currentSpiderbotAction")] 
		public CHandle<CustomDeviceAction> CurrentSpiderbotAction
		{
			get => GetProperty(ref _currentSpiderbotAction);
			set => SetProperty(ref _currentSpiderbotAction, value);
		}
	}
}
