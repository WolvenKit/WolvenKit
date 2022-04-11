using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionSlideToObjectNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		[Ordinal(4)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public CHandle<AIArgumentMapping> Offset
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
