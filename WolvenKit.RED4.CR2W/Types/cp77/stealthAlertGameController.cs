using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class stealthAlertGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _indicator_01;
		private inkImageWidgetReference _indicator_02;
		private inkImageWidgetReference _indicator_03;
		private inkWidgetReference _fluff_01;
		private inkWidgetReference _fluff_02;
		private inkWidgetReference _fluff_03;
		private inkWidgetReference _fluff_04;
		private CHandle<inkWidget> _root;
		private CUInt32 _securityBlackBoardID;
		private CUInt32 _playerBlackboardID;
		private CHandle<gameIBlackboard> _blackboard;
		private wCHandle<gameObject> _playerPuppet;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("indicator_01")] 
		public inkImageWidgetReference Indicator_01
		{
			get
			{
				if (_indicator_01 == null)
				{
					_indicator_01 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator_01", cr2w, this);
				}
				return _indicator_01;
			}
			set
			{
				if (_indicator_01 == value)
				{
					return;
				}
				_indicator_01 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("indicator_02")] 
		public inkImageWidgetReference Indicator_02
		{
			get
			{
				if (_indicator_02 == null)
				{
					_indicator_02 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator_02", cr2w, this);
				}
				return _indicator_02;
			}
			set
			{
				if (_indicator_02 == value)
				{
					return;
				}
				_indicator_02 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("indicator_03")] 
		public inkImageWidgetReference Indicator_03
		{
			get
			{
				if (_indicator_03 == null)
				{
					_indicator_03 = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "indicator_03", cr2w, this);
				}
				return _indicator_03;
			}
			set
			{
				if (_indicator_03 == value)
				{
					return;
				}
				_indicator_03 = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fluff_01")] 
		public inkWidgetReference Fluff_01
		{
			get
			{
				if (_fluff_01 == null)
				{
					_fluff_01 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fluff_01", cr2w, this);
				}
				return _fluff_01;
			}
			set
			{
				if (_fluff_01 == value)
				{
					return;
				}
				_fluff_01 = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("fluff_02")] 
		public inkWidgetReference Fluff_02
		{
			get
			{
				if (_fluff_02 == null)
				{
					_fluff_02 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fluff_02", cr2w, this);
				}
				return _fluff_02;
			}
			set
			{
				if (_fluff_02 == value)
				{
					return;
				}
				_fluff_02 = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fluff_03")] 
		public inkWidgetReference Fluff_03
		{
			get
			{
				if (_fluff_03 == null)
				{
					_fluff_03 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fluff_03", cr2w, this);
				}
				return _fluff_03;
			}
			set
			{
				if (_fluff_03 == value)
				{
					return;
				}
				_fluff_03 = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("fluff_04")] 
		public inkWidgetReference Fluff_04
		{
			get
			{
				if (_fluff_04 == null)
				{
					_fluff_04 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fluff_04", cr2w, this);
				}
				return _fluff_04;
			}
			set
			{
				if (_fluff_04 == value)
				{
					return;
				}
				_fluff_04 = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("securityBlackBoardID")] 
		public CUInt32 SecurityBlackBoardID
		{
			get
			{
				if (_securityBlackBoardID == null)
				{
					_securityBlackBoardID = (CUInt32) CR2WTypeManager.Create("Uint32", "securityBlackBoardID", cr2w, this);
				}
				return _securityBlackBoardID;
			}
			set
			{
				if (_securityBlackBoardID == value)
				{
					return;
				}
				_securityBlackBoardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("playerBlackboardID")] 
		public CUInt32 PlayerBlackboardID
		{
			get
			{
				if (_playerBlackboardID == null)
				{
					_playerBlackboardID = (CUInt32) CR2WTypeManager.Create("Uint32", "playerBlackboardID", cr2w, this);
				}
				return _playerBlackboardID;
			}
			set
			{
				if (_playerBlackboardID == value)
				{
					return;
				}
				_playerBlackboardID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		[Ordinal(22)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
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

		public stealthAlertGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
