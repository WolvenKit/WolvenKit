using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraShot : IScriptable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CInt32 Probability
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("scaleForVehicle")] 
		public CBool ScaleForVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CHandle<vehicleCinematicCameraShotRoot> Root
		{
			get => GetPropertyValue<CHandle<vehicleCinematicCameraShotRoot>>();
			set => SetPropertyValue<CHandle<vehicleCinematicCameraShotRoot>>(value);
		}

		[Ordinal(6)] 
		[RED("effects")] 
		public CArray<CHandle<vehicleCinematicCameraShotEffect>> Effects
		{
			get => GetPropertyValue<CArray<CHandle<vehicleCinematicCameraShotEffect>>>();
			set => SetPropertyValue<CArray<CHandle<vehicleCinematicCameraShotEffect>>>(value);
		}

		[Ordinal(7)] 
		[RED("stopConditions")] 
		public CArray<CHandle<vehicleCinematicCameraShotStopCondition>> StopConditions
		{
			get => GetPropertyValue<CArray<CHandle<vehicleCinematicCameraShotStopCondition>>>();
			set => SetPropertyValue<CArray<CHandle<vehicleCinematicCameraShotStopCondition>>>(value);
		}

		[Ordinal(8)] 
		[RED("runtimeData")] 
		public CinematicCameraData RuntimeData
		{
			get => GetPropertyValue<CinematicCameraData>();
			set => SetPropertyValue<CinematicCameraData>(value);
		}

		public vehicleCinematicCameraShot()
		{
			Enabled = true;
			Probability = 1;
			Duration = 1.000000F;
			ScaleForVehicle = true;
			Effects = new();
			StopConditions = new() { new vehicleCinematicCameraShotStopCondition_VehicleNotVisible(), new vehicleCinematicCameraShotStopCondition_VehicleDistanceFromCamera(), new vehicleCinematicCameraShotStopCondition_CollisionWithEnvironment() };
			RuntimeData = new CinematicCameraData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
