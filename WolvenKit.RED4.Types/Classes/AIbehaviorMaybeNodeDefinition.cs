using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorMaybeNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CEnum<AIbehaviorMaybeNodeAction> _onChildSuccess;
		private CEnum<AIbehaviorMaybeNodeAction> _onChildFailure;

		[Ordinal(1)] 
		[RED("onChildSuccess")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildSuccess
		{
			get => GetProperty(ref _onChildSuccess);
			set => SetProperty(ref _onChildSuccess, value);
		}

		[Ordinal(2)] 
		[RED("onChildFailure")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildFailure
		{
			get => GetProperty(ref _onChildFailure);
			set => SetProperty(ref _onChildFailure, value);
		}
	}
}
