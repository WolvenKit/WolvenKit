using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraph2DMultiVariablesNode : CBehaviorGraph2DVariableNode
	{
		[RED("variableName1")] 		public CName VariableName1 { get; set;}

		[RED("variableName2")] 		public CName VariableName2 { get; set;}

		public CBehaviorGraph2DMultiVariablesNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraph2DMultiVariablesNode(cr2w);

	}
}