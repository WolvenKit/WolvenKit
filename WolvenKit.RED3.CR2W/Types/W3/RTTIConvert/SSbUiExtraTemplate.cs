using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbUiExtraTemplate : CVariable
	{
		[Ordinal(1)] [RED("templatePath")] 		public CString TemplatePath { get; set;}

		[Ordinal(2)] [RED("caption")] 		public CString Caption { get; set;}

		[Ordinal(3)] [RED("subCategory1")] 		public CString SubCategory1 { get; set;}

		[Ordinal(4)] [RED("subCategory2")] 		public CString SubCategory2 { get; set;}

		public SSbUiExtraTemplate(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}