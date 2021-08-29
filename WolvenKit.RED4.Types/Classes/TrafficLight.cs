using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficLight : Device
	{
		private CEnum<worldTrafficLightColor> _lightState;
		private CHandle<entPhysicalMeshComponent> _trafficLightMesh;
		private CHandle<entPhysicalMeshComponent> _destroyedMesh;

		[Ordinal(87)] 
		[RED("lightState")] 
		public CEnum<worldTrafficLightColor> LightState
		{
			get => GetProperty(ref _lightState);
			set => SetProperty(ref _lightState, value);
		}

		[Ordinal(88)] 
		[RED("trafficLightMesh")] 
		public CHandle<entPhysicalMeshComponent> TrafficLightMesh
		{
			get => GetProperty(ref _trafficLightMesh);
			set => SetProperty(ref _trafficLightMesh, value);
		}

		[Ordinal(89)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetProperty(ref _destroyedMesh);
			set => SetProperty(ref _destroyedMesh, value);
		}
	}
}
