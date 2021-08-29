using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KillMarkerGameController : gameuiWidgetGameController
	{
		private CHandle<redCallbackObject> _targetNeutralized;
		private CWeakHandle<gameIBlackboard> _blackboard;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(2)] 
		[RED("targetNeutralized")] 
		public CHandle<redCallbackObject> TargetNeutralized
		{
			get => GetProperty(ref _targetNeutralized);
			set => SetProperty(ref _targetNeutralized, value);
		}

		[Ordinal(3)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(4)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}
	}
}
