using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLODDefinition : ISerializable
	{
		[Ordinal(0)] [RED("backgroundDistanceLODs", 4)] public CStatic<CFloat> BackgroundDistanceLODs { get; set; }
		[Ordinal(1)] [RED("regularDistanceLODs", 4)] public CStatic<CFloat> RegularDistanceLODs { get; set; }
		[Ordinal(2)] [RED("cinematicDistanceLODs", 4)] public CStatic<CFloat> CinematicDistanceLODs { get; set; }
		[Ordinal(3)] [RED("vehicleDistanceLODs", 4)] public CStatic<CFloat> VehicleDistanceLODs { get; set; }
		[Ordinal(4)] [RED("cinematicVehicleDistanceLODs", 4)] public CStatic<CFloat> CinematicVehicleDistanceLODs { get; set; }

		public entLODDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
