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
			get
			{
				if (_radioStationName == null)
				{
					_radioStationName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "radioStationName", cr2w, this);
				}
				return _radioStationName;
			}
			set
			{
				if (_radioStationName == value)
				{
					return;
				}
				_radioStationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("songName")] 
		public inkTextWidgetReference SongName
		{
			get
			{
				if (_songName == null)
				{
					_songName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "songName", cr2w, this);
				}
				return _songName;
			}
			set
			{
				if (_songName == value)
				{
					return;
				}
				_songName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get
			{
				if (_stateChangesBlackboardId == null)
				{
					_stateChangesBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "stateChangesBlackboardId", cr2w, this);
				}
				return _stateChangesBlackboardId;
			}
			set
			{
				if (_stateChangesBlackboardId == value)
				{
					return;
				}
				_stateChangesBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("songNameChangeBlackboardId")] 
		public CUInt32 SongNameChangeBlackboardId
		{
			get
			{
				if (_songNameChangeBlackboardId == null)
				{
					_songNameChangeBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "songNameChangeBlackboardId", cr2w, this);
				}
				return _songNameChangeBlackboardId;
			}
			set
			{
				if (_songNameChangeBlackboardId == value)
				{
					return;
				}
				_songNameChangeBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		public CarRadioGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
