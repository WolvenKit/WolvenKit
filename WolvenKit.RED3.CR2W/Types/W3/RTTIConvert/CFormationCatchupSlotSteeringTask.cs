using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFormationCatchupSlotSteeringTask : IFormationSteeringTask
	{
		[Ordinal(1)] [RED("speedImportance")] 		public CFloat SpeedImportance { get; set;}

		[Ordinal(2)] [RED("toleranceDistance")] 		public CFloat ToleranceDistance { get; set;}

		[Ordinal(3)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(4)] [RED("cachupSpeed")] 		public CFloat CachupSpeed { get; set;}

		public CFormationCatchupSlotSteeringTask(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFormationCatchupSlotSteeringTask(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}