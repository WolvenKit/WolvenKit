using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GetCurrentPatrolSpotActionPath : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("outPathArgument")] 
		public CHandle<AIArgumentMapping> OutPathArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public GetCurrentPatrolSpotActionPath()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
