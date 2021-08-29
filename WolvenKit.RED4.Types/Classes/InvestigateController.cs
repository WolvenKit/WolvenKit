using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InvestigateController : AIbehaviorconditionScript
	{
		private senseStimInvestigateData _investigateData;

		[Ordinal(0)] 
		[RED("investigateData")] 
		public senseStimInvestigateData InvestigateData
		{
			get => GetProperty(ref _investigateData);
			set => SetProperty(ref _investigateData, value);
		}
	}
}
