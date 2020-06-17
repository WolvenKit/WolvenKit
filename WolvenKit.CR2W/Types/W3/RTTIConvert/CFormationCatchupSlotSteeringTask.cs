using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFormationCatchupSlotSteeringTask : IFormationSteeringTask
	{
		[RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		[RED("toleranceDistance")] 		public CFloat ToleranceDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("cachupSpeed")] 		public CFloat CachupSpeed { get; set;}

		public CFormationCatchupSlotSteeringTask(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFormationCatchupSlotSteeringTask(cr2w);

	}
}