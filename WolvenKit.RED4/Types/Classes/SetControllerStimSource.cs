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
			InvestigateData = new senseStimInvestigateData { DistrationPoint = new Vector4(), AttackInstigatorPosition = new Vector4(), InvestigationSpots = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
