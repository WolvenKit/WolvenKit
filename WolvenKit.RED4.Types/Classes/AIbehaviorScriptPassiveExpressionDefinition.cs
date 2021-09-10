using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorScriptPassiveExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)] 
		[RED("script")] 
		public CHandle<AIbehaviorexpressionScript> Script
		{
			get => GetPropertyValue<CHandle<AIbehaviorexpressionScript>>();
			set => SetPropertyValue<CHandle<AIbehaviorexpressionScript>>(value);
		}
	}
}
