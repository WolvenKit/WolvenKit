using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KillMarkerGameController : gameuiWidgetGameController
	{
		private CHandle<redCallbackObject> _targetNeutralized;
		private wCHandle<gameIBlackboard> _blackboard;
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
		public wCHandle<gameIBlackboard> Blackboard
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

		public KillMarkerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
