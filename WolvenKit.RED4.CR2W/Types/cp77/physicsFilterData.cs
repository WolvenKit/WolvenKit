using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsFilterData : ISerializable
	{
		[Ordinal(0)] [RED("simulationFilter")] public physicsSimulationFilter SimulationFilter { get; set; }
		[Ordinal(1)] [RED("queryFilter")] public physicsQueryFilter QueryFilter { get; set; }
		[Ordinal(2)] [RED("preset")] public CName Preset { get; set; }
		[Ordinal(3)] [RED("customFilterData")] public CHandle<physicsCustomFilterData> CustomFilterData { get; set; }

		public physicsFilterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
