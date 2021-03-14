using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeathMenuGameController : gameuiMenuItemListGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CBool _loadComplete;
		private CHandle<inkanimProxy> _animIntro;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get
			{
				if (_loadComplete == null)
				{
					_loadComplete = (CBool) CR2WTypeManager.Create("Bool", "loadComplete", cr2w, this);
				}
				return _loadComplete;
			}
			set
			{
				if (_loadComplete == value)
				{
					return;
				}
				_loadComplete = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("animIntro")] 
		public CHandle<inkanimProxy> AnimIntro
		{
			get
			{
				if (_animIntro == null)
				{
					_animIntro = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animIntro", cr2w, this);
				}
				return _animIntro;
			}
			set
			{
				if (_animIntro == value)
				{
					return;
				}
				_animIntro = value;
				PropertySet(this);
			}
		}

		public DeathMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
