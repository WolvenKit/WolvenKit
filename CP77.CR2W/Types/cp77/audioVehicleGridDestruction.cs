using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGridDestruction : audioAudioMetadata
	{
		[Ordinal(1)] [RED("minGridCellRawChangeThreshold")] public CFloat MinGridCellRawChangeThreshold { get; set; }
		[Ordinal(2)] [RED("specificGridCellImpactCooldown")] public CFloat SpecificGridCellImpactCooldown { get; set; }
		[Ordinal(3)] [RED("minGridCellValueToPlayDetailedEvent")] public CFloat MinGridCellValueToPlayDetailedEvent { get; set; }
		[Ordinal(4)] [RED("bottomLayer")] public audioVehicleDestructionGridLayer BottomLayer { get; set; }
		[Ordinal(5)] [RED("upperLayer")] public audioVehicleDestructionGridLayer UpperLayer { get; set; }

		public audioVehicleGridDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
