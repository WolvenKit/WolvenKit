using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionUseWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _eventData;
		private CHandle<AIArgumentMapping> _playStartAnimationAfterwards;
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CHandle<AIArgumentMapping> _playExitAutomatically;
		private CHandle<AIArgumentMapping> _markUninterruptable;

		[Ordinal(1)] 
		[RED("eventData")] 
		public CHandle<AIArgumentMapping> EventData
		{
			get => GetProperty(ref _eventData);
			set => SetProperty(ref _eventData, value);
		}

		[Ordinal(2)] 
		[RED("playStartAnimationAfterwards")] 
		public CHandle<AIArgumentMapping> PlayStartAnimationAfterwards
		{
			get => GetProperty(ref _playStartAnimationAfterwards);
			set => SetProperty(ref _playStartAnimationAfterwards, value);
		}

		[Ordinal(3)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		[Ordinal(4)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get => GetProperty(ref _dependentWorkspotData);
			set => SetProperty(ref _dependentWorkspotData, value);
		}

		[Ordinal(5)] 
		[RED("playExitAutomatically")] 
		public CHandle<AIArgumentMapping> PlayExitAutomatically
		{
			get => GetProperty(ref _playExitAutomatically);
			set => SetProperty(ref _playExitAutomatically, value);
		}

		[Ordinal(6)] 
		[RED("markUninterruptable")] 
		public CHandle<AIArgumentMapping> MarkUninterruptable
		{
			get => GetProperty(ref _markUninterruptable);
			set => SetProperty(ref _markUninterruptable, value);
		}
	}
}
