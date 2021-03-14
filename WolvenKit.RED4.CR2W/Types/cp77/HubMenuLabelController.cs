using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubMenuLabelController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _container;
		private wCHandle<inkWidget> _wrapper;
		private wCHandle<inkWidget> _wrapperNext;
		private wCHandle<HubMenuLabelContentContainer> _wrapperController;
		private wCHandle<HubMenuLabelContentContainer> _wrapperNextController;
		private MenuData _data;
		private CBool _watchForSize;
		private CBool _watchForInstatnSize;
		private CBool _once;
		private CInt32 _direction;

		[Ordinal(1)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("wrapper")] 
		public wCHandle<inkWidget> Wrapper
		{
			get
			{
				if (_wrapper == null)
				{
					_wrapper = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "wrapper", cr2w, this);
				}
				return _wrapper;
			}
			set
			{
				if (_wrapper == value)
				{
					return;
				}
				_wrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("wrapperNext")] 
		public wCHandle<inkWidget> WrapperNext
		{
			get
			{
				if (_wrapperNext == null)
				{
					_wrapperNext = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "wrapperNext", cr2w, this);
				}
				return _wrapperNext;
			}
			set
			{
				if (_wrapperNext == value)
				{
					return;
				}
				_wrapperNext = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("wrapperController")] 
		public wCHandle<HubMenuLabelContentContainer> WrapperController
		{
			get
			{
				if (_wrapperController == null)
				{
					_wrapperController = (wCHandle<HubMenuLabelContentContainer>) CR2WTypeManager.Create("whandle:HubMenuLabelContentContainer", "wrapperController", cr2w, this);
				}
				return _wrapperController;
			}
			set
			{
				if (_wrapperController == value)
				{
					return;
				}
				_wrapperController = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("wrapperNextController")] 
		public wCHandle<HubMenuLabelContentContainer> WrapperNextController
		{
			get
			{
				if (_wrapperNextController == null)
				{
					_wrapperNextController = (wCHandle<HubMenuLabelContentContainer>) CR2WTypeManager.Create("whandle:HubMenuLabelContentContainer", "wrapperNextController", cr2w, this);
				}
				return _wrapperNextController;
			}
			set
			{
				if (_wrapperNextController == value)
				{
					return;
				}
				_wrapperNextController = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("data")] 
		public MenuData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (MenuData) CR2WTypeManager.Create("MenuData", "data", cr2w, this);
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

		[Ordinal(7)] 
		[RED("watchForSize")] 
		public CBool WatchForSize
		{
			get
			{
				if (_watchForSize == null)
				{
					_watchForSize = (CBool) CR2WTypeManager.Create("Bool", "watchForSize", cr2w, this);
				}
				return _watchForSize;
			}
			set
			{
				if (_watchForSize == value)
				{
					return;
				}
				_watchForSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("watchForInstatnSize")] 
		public CBool WatchForInstatnSize
		{
			get
			{
				if (_watchForInstatnSize == null)
				{
					_watchForInstatnSize = (CBool) CR2WTypeManager.Create("Bool", "watchForInstatnSize", cr2w, this);
				}
				return _watchForInstatnSize;
			}
			set
			{
				if (_watchForInstatnSize == value)
				{
					return;
				}
				_watchForInstatnSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("once")] 
		public CBool Once
		{
			get
			{
				if (_once == null)
				{
					_once = (CBool) CR2WTypeManager.Create("Bool", "once", cr2w, this);
				}
				return _once;
			}
			set
			{
				if (_once == value)
				{
					return;
				}
				_once = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CInt32) CR2WTypeManager.Create("Int32", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public HubMenuLabelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
