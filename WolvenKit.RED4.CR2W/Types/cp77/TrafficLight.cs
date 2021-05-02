using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficLight : Device
	{
		private CEnum<worldTrafficLightColor> _lightState;
		private CHandle<entPhysicalMeshComponent> _trafficLightMesh;
		private CHandle<entPhysicalMeshComponent> _destroyedMesh;

		[Ordinal(86)] 
		[RED("lightState")] 
		public CEnum<worldTrafficLightColor> LightState
		{
			get => GetProperty(ref _lightState);
			set => SetProperty(ref _lightState, value);
		}

		[Ordinal(87)] 
		[RED("trafficLightMesh")] 
		public CHandle<entPhysicalMeshComponent> TrafficLightMesh
		{
			get => GetProperty(ref _trafficLightMesh);
			set => SetProperty(ref _trafficLightMesh, value);
		}

		[Ordinal(88)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetProperty(ref _destroyedMesh);
			set => SetProperty(ref _destroyedMesh, value);
		}

		public TrafficLight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
