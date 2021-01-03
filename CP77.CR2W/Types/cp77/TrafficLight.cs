using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TrafficLight : Device
	{
		[Ordinal(0)]  [RED("destroyedMesh")] public CHandle<entPhysicalMeshComponent> DestroyedMesh { get; set; }
		[Ordinal(1)]  [RED("lightState")] public CEnum<worldTrafficLightColor> LightState { get; set; }
		[Ordinal(2)]  [RED("trafficLightMesh")] public CHandle<entPhysicalMeshComponent> TrafficLightMesh { get; set; }

		public TrafficLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
