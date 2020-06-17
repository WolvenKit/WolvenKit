using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCustomNode : CVariable
	{
		[RED("nodeName")] 		public CName NodeName { get; set;}

		[RED("attributes", 2,0)] 		public CArray<SCustomNodeAttribute> Attributes { get; set;}

		[RED("values", 2,0)] 		public CArray<CName> Values { get; set;}

		[RED("subNodes", 2,0)] 		public CArray<SCustomNode> SubNodes { get; set;}

		public SCustomNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCustomNode(cr2w);

	}
}