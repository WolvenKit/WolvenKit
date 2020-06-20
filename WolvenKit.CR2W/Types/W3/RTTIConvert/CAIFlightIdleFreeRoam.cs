using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlightIdleFreeRoam : IAIFlightIdleTree
	{
		[RED("flightHeight")] 		public CFloat FlightHeight { get; set;}

		[RED("flyAround")] 		public CBool FlyAround { get; set;}

		[RED("flyAroundDurationMin")] 		public CFloat FlyAroundDurationMin { get; set;}

		[RED("flyAroundDurationMax")] 		public CFloat FlyAroundDurationMax { get; set;}

		[RED("flightAreaSelection")] 		public CEnum<EAIAreaSelectionMode> FlightAreaSelection { get; set;}

		[RED("flightAreaOptionalTag")] 		public CName FlightAreaOptionalTag { get; set;}

		public CAIFlightIdleFreeRoam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlightIdleFreeRoam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}