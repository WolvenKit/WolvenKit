using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetControllerStimSource : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("investigateData")] 
		public senseStimInvestigateData InvestigateData
		{
			get => GetPropertyValue<senseStimInvestigateData>();
			set => SetPropertyValue<senseStimInvestigateData>(value);
		}

		public SetControllerStimSource()
		{
			InvestigateData = new() { DistrationPoint = new(), AttackInstigatorPosition = new(), InvestigationSpots = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
