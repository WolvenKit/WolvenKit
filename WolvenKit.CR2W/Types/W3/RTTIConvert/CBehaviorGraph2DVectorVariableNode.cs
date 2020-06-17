using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraph2DVectorVariableNode : CBehaviorGraph2DVariableNode
	{
		[RED("variableName")] 		public CName VariableName { get; set;}

		public CBehaviorGraph2DVectorVariableNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraph2DVectorVariableNode(cr2w);

	}
}