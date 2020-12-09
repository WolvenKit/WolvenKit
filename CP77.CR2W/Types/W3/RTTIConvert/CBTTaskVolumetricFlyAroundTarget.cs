using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskVolumetricFlyAroundTarget : CBTTaskVolumetricMove
	{
		[Ordinal(1)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(2)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(3)] [RED("flightMaxDuration")] 		public CFloat FlightMaxDuration { get; set;}

		[Ordinal(4)] [RED("npcToDestDistance")] 		public CFloat NpcToDestDistance { get; set;}

		[Ordinal(5)] [RED("flightStartTime")] 		public CFloat FlightStartTime { get; set;}

		[Ordinal(6)] [RED("flightDuration")] 		public CFloat FlightDuration { get; set;}

		public CBTTaskVolumetricFlyAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskVolumetricFlyAroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}