using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISpiderbotCheckIfFriendlyMoved : AIAutonomousConditions
	{
		[Ordinal(0)] 
		[RED("maxAllowedDelta")] 
		public CHandle<AIArgumentMapping> MaxAllowedDelta
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
