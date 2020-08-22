using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEntityBodyPart : CVariable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("states", 2,0)] 		public CArray<CEntityBodyPartState> States { get; set;}

		[RED("wasIncluded")] 		public CBool WasIncluded { get; set;}

		public CEntityBodyPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntityBodyPart(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}