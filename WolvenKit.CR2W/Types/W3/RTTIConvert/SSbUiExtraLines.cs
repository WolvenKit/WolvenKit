using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbUiExtraLines : CVariable
	{
		[RED("id")] 		public CInt32 Id { get; set;}

		[RED("subCategory1")] 		public CString SubCategory1 { get; set;}

		[RED("subCategory2")] 		public CString SubCategory2 { get; set;}

		[RED("caption")] 		public CString Caption { get; set;}

		public SSbUiExtraLines(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSbUiExtraLines(cr2w);

	}
}