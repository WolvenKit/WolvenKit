using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISpiderbotFindBoredMovePosition : AIFindPositionAroundSelf
	{
		[Ordinal(6)] 
		[RED("maxWanderDistance")] 
		public CHandle<AIArgumentMapping> MaxWanderDistance
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
