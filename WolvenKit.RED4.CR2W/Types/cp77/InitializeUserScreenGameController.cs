using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializeUserScreenGameController : gameuiMenuGameController
	{
		private inkVideoWidgetReference _backgroundVideo;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get
			{
				if (_backgroundVideo == null)
				{
					_backgroundVideo = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "backgroundVideo", cr2w, this);
				}
				return _backgroundVideo;
			}
			set
			{
				if (_backgroundVideo == value)
				{
					return;
				}
				_backgroundVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		public InitializeUserScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
