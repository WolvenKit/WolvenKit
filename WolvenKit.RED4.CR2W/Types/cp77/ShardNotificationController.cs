using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardNotificationController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _shortTextRef;
		private inkTextWidgetReference _longTextRef;
		private inkWidgetReference _shortTextHolderRef;
		private inkWidgetReference _longTextHolderRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _buttonHintsManagerParentRef;
		private inkWidgetReference _buttonHintsSecondaryManagerRef;
		private inkWidgetReference _buttonHintsSecondaryManagerParentRef;
		private CHandle<ShardReadPopupData> _data;
		private CInt32 _longTextTrashold;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameIBlackboard> _mingameBB;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("shortTextRef")] 
		public inkTextWidgetReference ShortTextRef
		{
			get
			{
				if (_shortTextRef == null)
				{
					_shortTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "shortTextRef", cr2w, this);
				}
				return _shortTextRef;
			}
			set
			{
				if (_shortTextRef == value)
				{
					return;
				}
				_shortTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("longTextRef")] 
		public inkTextWidgetReference LongTextRef
		{
			get
			{
				if (_longTextRef == null)
				{
					_longTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "longTextRef", cr2w, this);
				}
				return _longTextRef;
			}
			set
			{
				if (_longTextRef == value)
				{
					return;
				}
				_longTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("shortTextHolderRef")] 
		public inkWidgetReference ShortTextHolderRef
		{
			get
			{
				if (_shortTextHolderRef == null)
				{
					_shortTextHolderRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "shortTextHolderRef", cr2w, this);
				}
				return _shortTextHolderRef;
			}
			set
			{
				if (_shortTextHolderRef == value)
				{
					return;
				}
				_shortTextHolderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("longTextHolderRef")] 
		public inkWidgetReference LongTextHolderRef
		{
			get
			{
				if (_longTextHolderRef == null)
				{
					_longTextHolderRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "longTextHolderRef", cr2w, this);
				}
				return _longTextHolderRef;
			}
			set
			{
				if (_longTextHolderRef == value)
				{
					return;
				}
				_longTextHolderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerParentRef")] 
		public inkWidgetReference ButtonHintsManagerParentRef
		{
			get
			{
				if (_buttonHintsManagerParentRef == null)
				{
					_buttonHintsManagerParentRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerParentRef", cr2w, this);
				}
				return _buttonHintsManagerParentRef;
			}
			set
			{
				if (_buttonHintsManagerParentRef == value)
				{
					return;
				}
				_buttonHintsManagerParentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("buttonHintsSecondaryManagerRef")] 
		public inkWidgetReference ButtonHintsSecondaryManagerRef
		{
			get
			{
				if (_buttonHintsSecondaryManagerRef == null)
				{
					_buttonHintsSecondaryManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsSecondaryManagerRef", cr2w, this);
				}
				return _buttonHintsSecondaryManagerRef;
			}
			set
			{
				if (_buttonHintsSecondaryManagerRef == value)
				{
					return;
				}
				_buttonHintsSecondaryManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("buttonHintsSecondaryManagerParentRef")] 
		public inkWidgetReference ButtonHintsSecondaryManagerParentRef
		{
			get
			{
				if (_buttonHintsSecondaryManagerParentRef == null)
				{
					_buttonHintsSecondaryManagerParentRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsSecondaryManagerParentRef", cr2w, this);
				}
				return _buttonHintsSecondaryManagerParentRef;
			}
			set
			{
				if (_buttonHintsSecondaryManagerParentRef == value)
				{
					return;
				}
				_buttonHintsSecondaryManagerParentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<ShardReadPopupData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<ShardReadPopupData>) CR2WTypeManager.Create("handle:ShardReadPopupData", "data", cr2w, this);
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

		[Ordinal(12)] 
		[RED("longTextTrashold")] 
		public CInt32 LongTextTrashold
		{
			get
			{
				if (_longTextTrashold == null)
				{
					_longTextTrashold = (CInt32) CR2WTypeManager.Create("Int32", "longTextTrashold", cr2w, this);
				}
				return _longTextTrashold;
			}
			set
			{
				if (_longTextTrashold == value)
				{
					return;
				}
				_longTextTrashold = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
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

		[Ordinal(15)] 
		[RED("mingameBB")] 
		public CHandle<gameIBlackboard> MingameBB
		{
			get
			{
				if (_mingameBB == null)
				{
					_mingameBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "mingameBB", cr2w, this);
				}
				return _mingameBB;
			}
			set
			{
				if (_mingameBB == value)
				{
					return;
				}
				_mingameBB = value;
				PropertySet(this);
			}
		}

		public ShardNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
