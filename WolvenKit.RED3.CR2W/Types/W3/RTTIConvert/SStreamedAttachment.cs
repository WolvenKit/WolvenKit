using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStreamedAttachment : CVariable
	{
		[Ordinal(1)] [RED("parentName")] 		public CName ParentName { get; set;}

		[Ordinal(2)] [RED("parentClass")] 		public CName ParentClass { get; set;}

		[Ordinal(3)] [RED("childName")] 		public CName ChildName { get; set;}

		[Ordinal(4)] [RED("childClass")] 		public CName ChildClass { get; set;}

		[Ordinal(5)] [RED("data", 2,0)] 		public CByteArray Data { get; set;}

		public SStreamedAttachment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStreamedAttachment(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}