using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFormationCatchupSlotSteeringTask : IFormationSteeringTask
	{
		[Ordinal(0)] [RED("("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		[Ordinal(0)] [RED("("toleranceDistance")] 		public CFloat ToleranceDistance { get; set;}

		[Ordinal(0)] [RED("("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("("cachupSpeed")] 		public CFloat CachupSpeed { get; set;}

		public CFormationCatchupSlotSteeringTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFormationCatchupSlotSteeringTask(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}