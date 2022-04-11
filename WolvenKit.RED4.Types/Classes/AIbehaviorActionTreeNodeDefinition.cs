using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionTreeNodeDefinition : AIbehaviorLeafTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
