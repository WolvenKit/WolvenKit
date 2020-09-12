using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFoliageInstanceStatistics : CVariable
	{
		[Ordinal(1)] [RED("baseTree")] 		public CHandle<CSRTBaseTree> BaseTree { get; set;}

		[Ordinal(2)] [RED("instanceCount")] 		public CUInt32 InstanceCount { get; set;}

		public SFoliageInstanceStatistics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFoliageInstanceStatistics(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}