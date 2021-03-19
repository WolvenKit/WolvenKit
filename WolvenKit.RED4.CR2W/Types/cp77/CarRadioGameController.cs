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
		private CHandle<inkWidget> _root;
		private CUInt32 _stateChangesBlackboardId;
		private CUInt32 _songNameChangeBlackboardId;
		private CHandle<gameIBlackboard> _blackboard;
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
		public CHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(12)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get => GetProperty(ref _stateChangesBlackboardId);
			set => SetProperty(ref _stateChangesBlackboardId, value);
		}

		[Ordinal(13)] 
		[RED("songNameChangeBlackboardId")] 
		public CUInt32 SongNameChangeBlackboardId
		{
			get => GetProperty(ref _songNameChangeBlackboardId);
			set => SetProperty(ref _songNameChangeBlackboardId, value);
		}

		[Ordinal(14)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
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

		public CarRadioGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
