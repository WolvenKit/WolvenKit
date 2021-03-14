using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericNotificationController : gameuiGenericNotificationReceiverGameController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _textRef;
		private inkTextWidgetReference _actionLabelRef;
		private inkWidgetReference _actionRef;
		private CBool _blockAction;
		private CHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private CHandle<gameuiGenericNotificationViewData> _data;
		private wCHandle<gameObject> _player;
		private CBool _isInteractive;

		[Ordinal(3)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get
			{
				if (_titleRef == null)
				{
					_titleRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleRef", cr2w, this);
				}
				return _titleRef;
			}
			set
			{
				if (_titleRef == value)
				{
					return;
				}
				_titleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("textRef")] 
		public inkTextWidgetReference TextRef
		{
			get
			{
				if (_textRef == null)
				{
					_textRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textRef", cr2w, this);
				}
				return _textRef;
			}
			set
			{
				if (_textRef == value)
				{
					return;
				}
				_textRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actionLabelRef")] 
		public inkTextWidgetReference ActionLabelRef
		{
			get
			{
				if (_actionLabelRef == null)
				{
					_actionLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "actionLabelRef", cr2w, this);
				}
				return _actionLabelRef;
			}
			set
			{
				if (_actionLabelRef == value)
				{
					return;
				}
				_actionLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("actionRef")] 
		public inkWidgetReference ActionRef
		{
			get
			{
				if (_actionRef == null)
				{
					_actionRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "actionRef", cr2w, this);
				}
				return _actionRef;
			}
			set
			{
				if (_actionRef == value)
				{
					return;
				}
				_actionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("blockAction")] 
		public CBool BlockAction
		{
			get
			{
				if (_blockAction == null)
				{
					_blockAction = (CBool) CR2WTypeManager.Create("Bool", "blockAction", cr2w, this);
				}
				return _blockAction;
			}
			set
			{
				if (_blockAction == value)
				{
					return;
				}
				_blockAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("translationAnimationCtrl")] 
		public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get
			{
				if (_translationAnimationCtrl == null)
				{
					_translationAnimationCtrl = (CHandle<inkTextReplaceAnimationController>) CR2WTypeManager.Create("handle:inkTextReplaceAnimationController", "translationAnimationCtrl", cr2w, this);
				}
				return _translationAnimationCtrl;
			}
			set
			{
				if (_translationAnimationCtrl == value)
				{
					return;
				}
				_translationAnimationCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<gameuiGenericNotificationViewData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<gameuiGenericNotificationViewData>) CR2WTypeManager.Create("handle:gameuiGenericNotificationViewData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		public GenericNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
