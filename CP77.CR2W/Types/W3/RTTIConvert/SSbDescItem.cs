using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescItem : CVariable
	{
		[Ordinal(1)] [RED("uId")] 		public CString UId { get; set;}

		[Ordinal(2)] [RED("repoItemId")] 		public CString RepoItemId { get; set;}

		[Ordinal(3)] [RED("template")] 		public CString Template { get; set;}

		public SSbDescItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}