using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbUiExtraLines : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CInt32 Id { get; set;}

		[Ordinal(2)] [RED("subCategory1")] 		public CString SubCategory1 { get; set;}

		[Ordinal(3)] [RED("subCategory2")] 		public CString SubCategory2 { get; set;}

		[Ordinal(4)] [RED("caption")] 		public CString Caption { get; set;}

		public SSbUiExtraLines(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}