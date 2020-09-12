using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCustomNode : CVariable
	{
		[Ordinal(1)] [RED("nodeName")] 		public CName NodeName { get; set;}

		[Ordinal(2)] [RED("attributes", 2,0)] 		public CArray<SCustomNodeAttribute> Attributes { get; set;}

		[Ordinal(3)] [RED("values", 2,0)] 		public CArray<CName> Values { get; set;}

		[Ordinal(4)] [RED("subNodes", 2,0)] 		public CArray<SCustomNode> SubNodes { get; set;}

		public SCustomNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCustomNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}