using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskVolumetricFlyAroundTarget : CBTTaskVolumetricMove
	{
		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("flightMaxDuration")] 		public CFloat FlightMaxDuration { get; set;}

		[RED("npcToDestDistance")] 		public CFloat NpcToDestDistance { get; set;}

		[RED("flightStartTime")] 		public CFloat FlightStartTime { get; set;}

		[RED("flightDuration")] 		public CFloat FlightDuration { get; set;}

		public CBTTaskVolumetricFlyAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskVolumetricFlyAroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}