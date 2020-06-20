using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFlightIdleAroundTargets : IAIFlightIdleTree
	{
		[RED("flightTargetTag")] 		public CName FlightTargetTag { get; set;}

		[RED("flightAroundClosest")] 		public CBool FlightAroundClosest { get; set;}

		[RED("flightAroundReselect")] 		public CBool FlightAroundReselect { get; set;}

		[RED("flyAroundReselectDurationMin")] 		public CFloat FlyAroundReselectDurationMin { get; set;}

		[RED("flyAroundReselectDurationMax")] 		public CFloat FlyAroundReselectDurationMax { get; set;}

		[RED("idleFlightRadiusMin")] 		public CFloat IdleFlightRadiusMin { get; set;}

		[RED("idleFlightRadiusMax")] 		public CFloat IdleFlightRadiusMax { get; set;}

		[RED("idleFlightHeightMin")] 		public CFloat IdleFlightHeightMin { get; set;}

		[RED("idleFlightHeightMax")] 		public CFloat IdleFlightHeightMax { get; set;}

		public CAIFlightIdleAroundTargets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFlightIdleAroundTargets(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}