using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentFillMeshInfo : entdismembermentMeshInfo
	{
		[Ordinal(10)] [RED("Placement")] public CEnum<entdismembermentPlacementE> Placement { get; set; }
		[Ordinal(11)] [RED("Simulation")] public CEnum<entdismembermentSimulationTypeE> Simulation { get; set; }
		[Ordinal(12)] [RED("Dangle")] public entdismembermentDangleInfo Dangle { get; set; }

		public entdismembermentFillMeshInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
