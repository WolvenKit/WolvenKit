using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorExtractMountDataTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _mountEventData;
		private CHandle<AIArgumentMapping> _outWorkspotData;
		private CHandle<AIArgumentMapping> _outIsInstant;

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<AIArgumentMapping> MountEventData
		{
			get => GetProperty(ref _mountEventData);
			set => SetProperty(ref _mountEventData, value);
		}

		[Ordinal(2)] 
		[RED("outWorkspotData")] 
		public CHandle<AIArgumentMapping> OutWorkspotData
		{
			get => GetProperty(ref _outWorkspotData);
			set => SetProperty(ref _outWorkspotData, value);
		}

		[Ordinal(3)] 
		[RED("outIsInstant")] 
		public CHandle<AIArgumentMapping> OutIsInstant
		{
			get => GetProperty(ref _outIsInstant);
			set => SetProperty(ref _outIsInstant, value);
		}
	}
}
