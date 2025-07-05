using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPatrolCommandPrologue : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outPatrolPath")] 
		public CHandle<AIArgumentMapping> OutPatrolPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIPatrolCommandPrologue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
