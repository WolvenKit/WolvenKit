using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentFillMeshInfo : entdismembermentMeshInfo
	{
		[Ordinal(0)]  [RED("Placement")] public CEnum<entdismembermentPlacementE> Placement { get; set; }
		[Ordinal(1)]  [RED("Simulation")] public CEnum<entdismembermentSimulationTypeE> Simulation { get; set; }
		[Ordinal(2)]  [RED("Dangle")] public entdismembermentDangleInfo Dangle { get; set; }

		public entdismembermentFillMeshInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
