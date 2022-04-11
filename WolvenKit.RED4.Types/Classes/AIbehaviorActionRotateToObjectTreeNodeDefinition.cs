using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionRotateToObjectTreeNodeDefinition : AIbehaviorActionRotateBaseTreeNodeDefinition
	{
		[Ordinal(5)] 
		[RED("completeWhenRotated")] 
		public CHandle<AIArgumentMapping> CompleteWhenRotated
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
