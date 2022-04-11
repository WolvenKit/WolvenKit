using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSaveEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] 
		[RED("eventData")] 
		public CHandle<AIArgumentMapping> EventData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
