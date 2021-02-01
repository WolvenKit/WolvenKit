using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridLayer : CVariable
	{
		[Ordinal(0)]  [RED("backLeft")] public audioVehicleDestructionGridCell BackLeft { get; set; }
		[Ordinal(1)]  [RED("backRight")] public audioVehicleDestructionGridCell BackRight { get; set; }
		[Ordinal(2)]  [RED("centerBackLeft")] public audioVehicleDestructionGridCell CenterBackLeft { get; set; }
		[Ordinal(3)]  [RED("centerBackRight")] public audioVehicleDestructionGridCell CenterBackRight { get; set; }
		[Ordinal(4)]  [RED("centerForwardLeft")] public audioVehicleDestructionGridCell CenterForwardLeft { get; set; }
		[Ordinal(5)]  [RED("centerForwardRight")] public audioVehicleDestructionGridCell CenterForwardRight { get; set; }
		[Ordinal(6)]  [RED("frontLeft")] public audioVehicleDestructionGridCell FrontLeft { get; set; }
		[Ordinal(7)]  [RED("frontRight")] public audioVehicleDestructionGridCell FrontRight { get; set; }

		public audioVehicleDestructionGridLayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
