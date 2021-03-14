using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WarningMessageGameController : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _root;
		private inkTextWidgetReference _mainTextWidget;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_NotificationsDef> _blackboardDef;
		private CUInt32 _warningMessageCallbackId;
		private gameSimpleScreenMessage _simpleMessage;
		private CHandle<inkanimDefinition> _blinkingAnim;
		private CHandle<inkanimDefinition> _showAnim;
		private CHandle<inkanimDefinition> _hideAnim;
		private CHandle<inkanimProxy> _animProxyShow;
		private CHandle<inkanimProxy> _animProxyHide;
		private CHandle<inkanimProxy> _animProxyTimeout;

		[Ordinal(9)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
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

		[Ordinal(10)] 
		[RED("mainTextWidget")] 
		public inkTextWidgetReference MainTextWidget
		{
			get
			{
				if (_mainTextWidget == null)
				{
					_mainTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "mainTextWidget", cr2w, this);
				}
				return _mainTextWidget;
			}
			set
			{
				if (_mainTextWidget == value)
				{
					return;
				}
				_mainTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get
			{
				if (_blackboardDef == null)
				{
					_blackboardDef = (CHandle<UI_NotificationsDef>) CR2WTypeManager.Create("handle:UI_NotificationsDef", "blackboardDef", cr2w, this);
				}
				return _blackboardDef;
			}
			set
			{
				if (_blackboardDef == value)
				{
					return;
				}
				_blackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("warningMessageCallbackId")] 
		public CUInt32 WarningMessageCallbackId
		{
			get
			{
				if (_warningMessageCallbackId == null)
				{
					_warningMessageCallbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "warningMessageCallbackId", cr2w, this);
				}
				return _warningMessageCallbackId;
			}
			set
			{
				if (_warningMessageCallbackId == value)
				{
					return;
				}
				_warningMessageCallbackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("simpleMessage")] 
		public gameSimpleScreenMessage SimpleMessage
		{
			get
			{
				if (_simpleMessage == null)
				{
					_simpleMessage = (gameSimpleScreenMessage) CR2WTypeManager.Create("gameSimpleScreenMessage", "simpleMessage", cr2w, this);
				}
				return _simpleMessage;
			}
			set
			{
				if (_simpleMessage == value)
				{
					return;
				}
				_simpleMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("blinkingAnim")] 
		public CHandle<inkanimDefinition> BlinkingAnim
		{
			get
			{
				if (_blinkingAnim == null)
				{
					_blinkingAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "blinkingAnim", cr2w, this);
				}
				return _blinkingAnim;
			}
			set
			{
				if (_blinkingAnim == value)
				{
					return;
				}
				_blinkingAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("showAnim")] 
		public CHandle<inkanimDefinition> ShowAnim
		{
			get
			{
				if (_showAnim == null)
				{
					_showAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "showAnim", cr2w, this);
				}
				return _showAnim;
			}
			set
			{
				if (_showAnim == value)
				{
					return;
				}
				_showAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hideAnim")] 
		public CHandle<inkanimDefinition> HideAnim
		{
			get
			{
				if (_hideAnim == null)
				{
					_hideAnim = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "hideAnim", cr2w, this);
				}
				return _hideAnim;
			}
			set
			{
				if (_hideAnim == value)
				{
					return;
				}
				_hideAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animProxyShow")] 
		public CHandle<inkanimProxy> AnimProxyShow
		{
			get
			{
				if (_animProxyShow == null)
				{
					_animProxyShow = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxyShow", cr2w, this);
				}
				return _animProxyShow;
			}
			set
			{
				if (_animProxyShow == value)
				{
					return;
				}
				_animProxyShow = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animProxyHide")] 
		public CHandle<inkanimProxy> AnimProxyHide
		{
			get
			{
				if (_animProxyHide == null)
				{
					_animProxyHide = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxyHide", cr2w, this);
				}
				return _animProxyHide;
			}
			set
			{
				if (_animProxyHide == value)
				{
					return;
				}
				_animProxyHide = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("animProxyTimeout")] 
		public CHandle<inkanimProxy> AnimProxyTimeout
		{
			get
			{
				if (_animProxyTimeout == null)
				{
					_animProxyTimeout = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxyTimeout", cr2w, this);
				}
				return _animProxyTimeout;
			}
			set
			{
				if (_animProxyTimeout == value)
				{
					return;
				}
				_animProxyTimeout = value;
				PropertySet(this);
			}
		}

		public WarningMessageGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
