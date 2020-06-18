using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBehaviorGraphContainerNode : CBehaviorGraphNode
	{
		[RED("mimicInputs", 2,0)] 		public CArray<CName> MimicInputs { get; set;}

		[RED("vectorValueInputs", 2,0)] 		public CArray<CName> VectorValueInputs { get; set;}

		public CBehaviorGraphContainerNode(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphContainerNode(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}