using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAvoidPlayerTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("threatRadius")] 
		public CHandle<AIArgumentMapping> ThreatRadius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
