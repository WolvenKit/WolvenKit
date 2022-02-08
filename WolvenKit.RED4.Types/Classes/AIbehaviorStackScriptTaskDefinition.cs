using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorStackScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviortaskStackScript> Script
		{
			get => GetPropertyValue<CHandle<AIbehaviortaskStackScript>>();
			set => SetPropertyValue<CHandle<AIbehaviortaskStackScript>>(value);
		}
	}
}
