using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressionNotification : GenericNotificationController
	{
		private CHandle<gameuiProgressionViewData> _progression_data;
		private inkWidgetReference _expBar;
		private inkTextWidgetReference _expText;
		private inkWidgetReference _barFG;
		private inkWidgetReference _barBG;
		private inkWidgetReference _root;
		private inkTextWidgetReference _currentLevel;
		private inkTextWidgetReference _nextLevel;
		private CFloat _expBarWidthSize;
		private CFloat _expBarHeightSize;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _barAnimationProxy;

		[Ordinal(12)] 
		[RED("progression_data")] 
		public CHandle<gameuiProgressionViewData> Progression_data
		{
			get
			{
				if (_progression_data == null)
				{
					_progression_data = (CHandle<gameuiProgressionViewData>) CR2WTypeManager.Create("handle:gameuiProgressionViewData", "progression_data", cr2w, this);
				}
				return _progression_data;
			}
			set
			{
				if (_progression_data == value)
				{
					return;
				}
				_progression_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get
			{
				if (_expBar == null)
				{
					_expBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "expBar", cr2w, this);
				}
				return _expBar;
			}
			set
			{
				if (_expBar == value)
				{
					return;
				}
				_expBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get
			{
				if (_expText == null)
				{
					_expText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "expText", cr2w, this);
				}
				return _expText;
			}
			set
			{
				if (_expText == value)
				{
					return;
				}
				_expText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("barFG")] 
		public inkWidgetReference BarFG
		{
			get
			{
				if (_barFG == null)
				{
					_barFG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "barFG", cr2w, this);
				}
				return _barFG;
			}
			set
			{
				if (_barFG == value)
				{
					return;
				}
				_barFG = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("barBG")] 
		public inkWidgetReference BarBG
		{
			get
			{
				if (_barBG == null)
				{
					_barBG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "barBG", cr2w, this);
				}
				return _barBG;
			}
			set
			{
				if (_barBG == value)
				{
					return;
				}
				_barBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
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

		[Ordinal(18)] 
		[RED("currentLevel")] 
		public inkTextWidgetReference CurrentLevel
		{
			get
			{
				if (_currentLevel == null)
				{
					_currentLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentLevel", cr2w, this);
				}
				return _currentLevel;
			}
			set
			{
				if (_currentLevel == value)
				{
					return;
				}
				_currentLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("nextLevel")] 
		public inkTextWidgetReference NextLevel
		{
			get
			{
				if (_nextLevel == null)
				{
					_nextLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nextLevel", cr2w, this);
				}
				return _nextLevel;
			}
			set
			{
				if (_nextLevel == value)
				{
					return;
				}
				_nextLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("expBarWidthSize")] 
		public CFloat ExpBarWidthSize
		{
			get
			{
				if (_expBarWidthSize == null)
				{
					_expBarWidthSize = (CFloat) CR2WTypeManager.Create("Float", "expBarWidthSize", cr2w, this);
				}
				return _expBarWidthSize;
			}
			set
			{
				if (_expBarWidthSize == value)
				{
					return;
				}
				_expBarWidthSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("expBarHeightSize")] 
		public CFloat ExpBarHeightSize
		{
			get
			{
				if (_expBarHeightSize == null)
				{
					_expBarHeightSize = (CFloat) CR2WTypeManager.Create("Float", "expBarHeightSize", cr2w, this);
				}
				return _expBarHeightSize;
			}
			set
			{
				if (_expBarHeightSize == value)
				{
					return;
				}
				_expBarHeightSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("barAnimationProxy")] 
		public CHandle<inkanimProxy> BarAnimationProxy
		{
			get
			{
				if (_barAnimationProxy == null)
				{
					_barAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "barAnimationProxy", cr2w, this);
				}
				return _barAnimationProxy;
			}
			set
			{
				if (_barAnimationProxy == value)
				{
					return;
				}
				_barAnimationProxy = value;
				PropertySet(this);
			}
		}

		public ProgressionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
