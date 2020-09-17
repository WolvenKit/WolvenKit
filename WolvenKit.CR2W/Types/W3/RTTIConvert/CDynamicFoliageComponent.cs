using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDynamicFoliageComponent : CComponent
	{
		[Ordinal(1)] [RED("baseTree")] 		public CSoft<CSRTBaseTree> BaseTree { get; set;}

		[Ordinal(2)] [RED("minimumStreamingDistance")] 		public CUInt32 MinimumStreamingDistance { get; set;}

		public CDynamicFoliageComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDynamicFoliageComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}