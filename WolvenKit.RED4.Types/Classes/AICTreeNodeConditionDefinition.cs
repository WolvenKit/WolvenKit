using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeConditionDefinition : AICTreeNodeCompositeDefinition
	{
		private CArray<CHandle<LibTreeINodeDefinition>> _expressions;
		private CHandle<LibTreeINodeDefinition> _trueBranch;
		private CHandle<LibTreeINodeDefinition> _falseBranch;
		private CBool _reevaluateOnExecution;

		[Ordinal(0)] 
		[RED("expressions")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Expressions
		{
			get => GetProperty(ref _expressions);
			set => SetProperty(ref _expressions, value);
		}

		[Ordinal(1)] 
		[RED("trueBranch")] 
		public CHandle<LibTreeINodeDefinition> TrueBranch
		{
			get => GetProperty(ref _trueBranch);
			set => SetProperty(ref _trueBranch, value);
		}

		[Ordinal(2)] 
		[RED("falseBranch")] 
		public CHandle<LibTreeINodeDefinition> FalseBranch
		{
			get => GetProperty(ref _falseBranch);
			set => SetProperty(ref _falseBranch, value);
		}

		[Ordinal(3)] 
		[RED("reevaluateOnExecution")] 
		public CBool ReevaluateOnExecution
		{
			get => GetProperty(ref _reevaluateOnExecution);
			set => SetProperty(ref _reevaluateOnExecution, value);
		}

		public AICTreeNodeConditionDefinition()
		{
			_reevaluateOnExecution = true;
		}
	}
}
