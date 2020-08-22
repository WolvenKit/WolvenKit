using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphInternalVariableCounterNode : CBehaviorGraphBaseNode
	{
		[RED("variableName")] 		public CName VariableName { get; set;}

		[RED("countOnActivation")] 		public CBool CountOnActivation { get; set;}

		[RED("countOnDeactivation")] 		public CBool CountOnDeactivation { get; set;}

		[RED("stepValue")] 		public CFloat StepValue { get; set;}

		public CBehaviorGraphInternalVariableCounterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphInternalVariableCounterNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}