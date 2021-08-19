using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarRadioGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _radioStationName;
		private inkTextWidgetReference _songName;
		private wCHandle<inkWidget> _root;
		private CHandle<redCallbackObject> _stateChangesBlackboardId;
		private CHandle<redCallbackObject> _songNameChangeBlackboardId;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
		[RED("radioStationName")] 
		public inkTextWidgetReference RadioStationName
		{
			get => GetProperty(ref _radioStationName);
			set => SetProperty(ref _radioStationName, value);
		}

		[Ordinal(10)] 
		[RED("songName")] 
		public inkTextWidgetReference SongName
		{
			get => GetProperty(ref _songName);
			set => SetProperty(ref _songName, value);
		}

		[Ordinal(11)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(12)] 
		[RED("stateChangesBlackboardId")] 
		public CHandle<redCallbackObject> StateChangesBlackboardId
		{
			get => GetProperty(ref _stateChangesBlackboardId);
			set => SetProperty(ref _stateChangesBlackboardId, value);
		}

		[Ordinal(13)] 
		[RED("songNameChangeBlackboardId")] 
		public CHandle<redCallbackObject> SongNameChangeBlackboardId
		{
			get => GetProperty(ref _songNameChangeBlackboardId);
			set => SetProperty(ref _songNameChangeBlackboardId, value);
		}

		[Ordinal(14)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		public CarRadioGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
