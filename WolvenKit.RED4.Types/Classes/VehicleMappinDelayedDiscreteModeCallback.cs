using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleMappinDelayedDiscreteModeCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private CWeakHandle<VehicleMappinComponent> _vehicleMappinComponent;

		[Ordinal(0)] 
		[RED("vehicleMappinComponent")] 
		public CWeakHandle<VehicleMappinComponent> VehicleMappinComponent
		{
			get => GetProperty(ref _vehicleMappinComponent);
			set => SetProperty(ref _vehicleMappinComponent, value);
		}
	}
}
