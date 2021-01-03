using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGridDestruction : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("bottomLayer")] public audioVehicleDestructionGridLayer BottomLayer { get; set; }
		[Ordinal(1)]  [RED("minGridCellRawChangeThreshold")] public CFloat MinGridCellRawChangeThreshold { get; set; }
		[Ordinal(2)]  [RED("minGridCellValueToPlayDetailedEvent")] public CFloat MinGridCellValueToPlayDetailedEvent { get; set; }
		[Ordinal(3)]  [RED("specificGridCellImpactCooldown")] public CFloat SpecificGridCellImpactCooldown { get; set; }
		[Ordinal(4)]  [RED("upperLayer")] public audioVehicleDestructionGridLayer UpperLayer { get; set; }

		public audioVehicleGridDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
