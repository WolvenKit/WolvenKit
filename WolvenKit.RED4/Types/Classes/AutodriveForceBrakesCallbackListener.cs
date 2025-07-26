using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutodriveForceBrakesCallbackListener : vehicleForceBrakesCallbackListener
	{
		[Ordinal(0)] 
		[RED("autodriveSystem")] 
		public CWeakHandle<AutoDriveSystem> AutodriveSystem
		{
			get => GetPropertyValue<CWeakHandle<AutoDriveSystem>>();
			set => SetPropertyValue<CWeakHandle<AutoDriveSystem>>(value);
		}

		public AutodriveForceBrakesCallbackListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
