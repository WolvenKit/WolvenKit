using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorFindAlertedWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _usedTokens;
		private CHandle<AIArgumentMapping> _spots;
		private CHandle<AIArgumentMapping> _radius;
		private CHandle<AIArgumentMapping> _outWorkspotData;

		[Ordinal(1)] 
		[RED("usedTokens")] 
		public CHandle<AIArgumentMapping> UsedTokens
		{
			get => GetProperty(ref _usedTokens);
			set => SetProperty(ref _usedTokens, value);
		}

		[Ordinal(2)] 
		[RED("spots")] 
		public CHandle<AIArgumentMapping> Spots
		{
			get => GetProperty(ref _spots);
			set => SetProperty(ref _spots, value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CHandle<AIArgumentMapping> Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(4)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get => GetProperty(ref _outWorkspotData);
			set => SetProperty(ref _outWorkspotData, value);
		}
	}
}
