using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlightIdleFreeRoam : IAIFlightIdleTree
	{
		[Ordinal(1)] [RED("flightHeight")] 		public CFloat FlightHeight { get; set;}

		[Ordinal(2)] [RED("flyAround")] 		public CBool FlyAround { get; set;}

		[Ordinal(3)] [RED("flyAroundDurationMin")] 		public CFloat FlyAroundDurationMin { get; set;}

		[Ordinal(4)] [RED("flyAroundDurationMax")] 		public CFloat FlyAroundDurationMax { get; set;}

		[Ordinal(5)] [RED("flightAreaSelection")] 		public CEnum<EAIAreaSelectionMode> FlightAreaSelection { get; set;}

		[Ordinal(6)] [RED("flightAreaOptionalTag")] 		public CName FlightAreaOptionalTag { get; set;}

		public CAIFlightIdleFreeRoam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlightIdleFreeRoam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}