using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entLODDefinition : ISerializable
	{
		[Ordinal(0)]  [RED("backgroundDistanceLODs")] public CStatic<4,Float> BackgroundDistanceLODs { get; set; }
		[Ordinal(1)]  [RED("cinematicDistanceLODs")] public CStatic<4,Float> CinematicDistanceLODs { get; set; }
		[Ordinal(2)]  [RED("cinematicVehicleDistanceLODs")] public CStatic<4,Float> CinematicVehicleDistanceLODs { get; set; }
		[Ordinal(3)]  [RED("regularDistanceLODs")] public CStatic<4,Float> RegularDistanceLODs { get; set; }
		[Ordinal(4)]  [RED("vehicleDistanceLODs")] public CStatic<4,Float> VehicleDistanceLODs { get; set; }

		public entLODDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
