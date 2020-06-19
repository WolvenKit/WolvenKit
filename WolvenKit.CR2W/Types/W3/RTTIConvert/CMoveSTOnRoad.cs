using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTOnRoad : IMoveSteeringTask
	{
		[RED("headingImportance")] 		public CFloat HeadingImportance { get; set;}

		[RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		[RED("anticipatedPositionDistance")] 		public CFloat AnticipatedPositionDistance { get; set;}

		[RED("roadMaxDist")] 		public CFloat RoadMaxDist { get; set;}

		public CMoveSTOnRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTOnRoad(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}