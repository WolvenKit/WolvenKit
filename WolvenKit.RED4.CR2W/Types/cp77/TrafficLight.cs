using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficLight : Device
	{
		[Ordinal(86)] [RED("lightState")] public CEnum<worldTrafficLightColor> LightState { get; set; }
		[Ordinal(87)] [RED("trafficLightMesh")] public CHandle<entPhysicalMeshComponent> TrafficLightMesh { get; set; }
		[Ordinal(88)] [RED("destroyedMesh")] public CHandle<entPhysicalMeshComponent> DestroyedMesh { get; set; }

		public TrafficLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
