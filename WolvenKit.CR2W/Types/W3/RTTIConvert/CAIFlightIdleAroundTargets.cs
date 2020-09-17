using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlightIdleAroundTargets : IAIFlightIdleTree
	{
		[Ordinal(1)] [RED("flightTargetTag")] 		public CName FlightTargetTag { get; set;}

		[Ordinal(2)] [RED("flightAroundClosest")] 		public CBool FlightAroundClosest { get; set;}

		[Ordinal(3)] [RED("flightAroundReselect")] 		public CBool FlightAroundReselect { get; set;}

		[Ordinal(4)] [RED("flyAroundReselectDurationMin")] 		public CFloat FlyAroundReselectDurationMin { get; set;}

		[Ordinal(5)] [RED("flyAroundReselectDurationMax")] 		public CFloat FlyAroundReselectDurationMax { get; set;}

		[Ordinal(6)] [RED("idleFlightRadiusMin")] 		public CFloat IdleFlightRadiusMin { get; set;}

		[Ordinal(7)] [RED("idleFlightRadiusMax")] 		public CFloat IdleFlightRadiusMax { get; set;}

		[Ordinal(8)] [RED("idleFlightHeightMin")] 		public CFloat IdleFlightHeightMin { get; set;}

		[Ordinal(9)] [RED("idleFlightHeightMax")] 		public CFloat IdleFlightHeightMax { get; set;}

		public CAIFlightIdleAroundTargets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlightIdleAroundTargets(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}