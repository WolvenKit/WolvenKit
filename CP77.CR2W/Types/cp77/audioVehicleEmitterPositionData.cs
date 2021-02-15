using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleEmitterPositionData : CVariable
	{
		[Ordinal(0)] [RED("engineEmitterPosition")] public Vector3 EngineEmitterPosition { get; set; }
		[Ordinal(1)] [RED("exaustEmitterPosition")] public Vector3 ExaustEmitterPosition { get; set; }
		[Ordinal(2)] [RED("centralEmitterPosition")] public Vector3 CentralEmitterPosition { get; set; }
		[Ordinal(3)] [RED("hoodEmitterPosition")] public Vector3 HoodEmitterPosition { get; set; }
		[Ordinal(4)] [RED("trunkEmitterPosition")] public Vector3 TrunkEmitterPosition { get; set; }
		[Ordinal(5)] [RED("wheel1Position")] public Vector3 Wheel1Position { get; set; }
		[Ordinal(6)] [RED("wheel2Position")] public Vector3 Wheel2Position { get; set; }
		[Ordinal(7)] [RED("wheel3Position")] public Vector3 Wheel3Position { get; set; }
		[Ordinal(8)] [RED("wheel4Position")] public Vector3 Wheel4Position { get; set; }

		public audioVehicleEmitterPositionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
