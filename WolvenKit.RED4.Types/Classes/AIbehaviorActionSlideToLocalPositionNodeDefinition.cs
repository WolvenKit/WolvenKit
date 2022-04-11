using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionSlideToLocalPositionNodeDefinition : AIbehaviorActionSlideNodeDefinition
	{
		[Ordinal(4)] 
		[RED("localOffset")] 
		public CHandle<AIArgumentMapping> LocalOffset
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
