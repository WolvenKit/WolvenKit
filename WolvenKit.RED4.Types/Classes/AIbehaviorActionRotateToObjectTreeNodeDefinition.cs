using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionRotateToObjectTreeNodeDefinition : AIbehaviorActionRotateBaseTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _completeWhenRotated;

		[Ordinal(5)] 
		[RED("completeWhenRotated")] 
		public CHandle<AIArgumentMapping> CompleteWhenRotated
		{
			get => GetProperty(ref _completeWhenRotated);
			set => SetProperty(ref _completeWhenRotated, value);
		}
	}
}
