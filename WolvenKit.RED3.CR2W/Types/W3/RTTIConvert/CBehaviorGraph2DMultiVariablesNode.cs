using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraph2DMultiVariablesNode : CBehaviorGraph2DVariableNode
	{
		[Ordinal(1)] [RED("variableName1")] 		public CName VariableName1 { get; set;}

		[Ordinal(2)] [RED("variableName2")] 		public CName VariableName2 { get; set;}

		public CBehaviorGraph2DMultiVariablesNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}