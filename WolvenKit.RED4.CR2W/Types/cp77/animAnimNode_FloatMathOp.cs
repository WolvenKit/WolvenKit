using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatMathOp : animAnimNode_FloatValue
	{
		private CEnum<animEAnimGraphMathOp> _operationType;
		private animFloatLink _firstInputNode;
		private animFloatLink _secondInputNode;

		[Ordinal(11)] 
		[RED("operationType")] 
		public CEnum<animEAnimGraphMathOp> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(12)] 
		[RED("firstInputNode")] 
		public animFloatLink FirstInputNode
		{
			get => GetProperty(ref _firstInputNode);
			set => SetProperty(ref _firstInputNode, value);
		}

		[Ordinal(13)] 
		[RED("secondInputNode")] 
		public animFloatLink SecondInputNode
		{
			get => GetProperty(ref _secondInputNode);
			set => SetProperty(ref _secondInputNode, value);
		}

		public animAnimNode_FloatMathOp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
