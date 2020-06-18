using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInternalVariableStateTransitionCondition : IBehaviorStateTransitionCondition
	{
		[RED("variableName")] 		public CName VariableName { get; set;}

		[RED("compareValue")] 		public CFloat CompareValue { get; set;}

		[RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CInternalVariableStateTransitionCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CInternalVariableStateTransitionCondition(cr2w);

	}
}