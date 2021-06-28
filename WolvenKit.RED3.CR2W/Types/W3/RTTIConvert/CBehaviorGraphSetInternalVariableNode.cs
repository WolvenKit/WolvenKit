using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSetInternalVariableNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("variableName")] 		public CName VariableName { get; set;}

		[Ordinal(2)] [RED("setValueOnActivationAsWell")] 		public CBool SetValueOnActivationAsWell { get; set;}

		[Ordinal(3)] [RED("setValueBeforeInputIsUpdated")] 		public CBool SetValueBeforeInputIsUpdated { get; set;}

		[Ordinal(4)] [RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		public CBehaviorGraphSetInternalVariableNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}