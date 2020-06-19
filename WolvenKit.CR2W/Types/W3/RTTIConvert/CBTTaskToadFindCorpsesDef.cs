using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadFindCorpsesDef : IBehTreeTaskDefinition
	{
		[RED("searchRange")] 		public CFloat SearchRange { get; set;}

		[RED("maxResults")] 		public CInt32 MaxResults { get; set;}

		[RED("tag")] 		public CName Tag { get; set;}

		public CBTTaskToadFindCorpsesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskToadFindCorpsesDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}