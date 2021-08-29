using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatMathOp : animAnimNode_FloatValue
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
	}
}
