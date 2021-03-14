using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScrollController : inkWidgetLogicController
	{
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _verticalScrollBarRef;
		private inkWidgetReference _navigableCompoundWidget;
		private inkCompoundWidgetReference _compoundWidgetRef;
		private CBool _autoHideVertical;
		private CFloat _scrollSpeedGamepad;
		private CFloat _scrollSpeedMouse;
		private CEnum<inkEScrollDirection> _direction;
		private CBool _useGlobalInput;
		private CFloat _position;
		private CFloat _scrollDelta;
		private Vector2 _viewportSize;
		private Vector2 _contentSize;

		[Ordinal(1)] 
		[RED("ScrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get
			{
				if (_scrollArea == null)
				{
					_scrollArea = (inkScrollAreaWidgetReference) CR2WTypeManager.Create("inkScrollAreaWidgetReference", "ScrollArea", cr2w, this);
				}
				return _scrollArea;
			}
			set
			{
				if (_scrollArea == value)
				{
					return;
				}
				_scrollArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("VerticalScrollBarRef")] 
		public inkWidgetReference VerticalScrollBarRef
		{
			get
			{
				if (_verticalScrollBarRef == null)
				{
					_verticalScrollBarRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "VerticalScrollBarRef", cr2w, this);
				}
				return _verticalScrollBarRef;
			}
			set
			{
				if (_verticalScrollBarRef == value)
				{
					return;
				}
				_verticalScrollBarRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("navigableCompoundWidget")] 
		public inkWidgetReference NavigableCompoundWidget
		{
			get
			{
				if (_navigableCompoundWidget == null)
				{
					_navigableCompoundWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "navigableCompoundWidget", cr2w, this);
				}
				return _navigableCompoundWidget;
			}
			set
			{
				if (_navigableCompoundWidget == value)
				{
					return;
				}
				_navigableCompoundWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("CompoundWidgetRef")] 
		public inkCompoundWidgetReference CompoundWidgetRef
		{
			get
			{
				if (_compoundWidgetRef == null)
				{
					_compoundWidgetRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "CompoundWidgetRef", cr2w, this);
				}
				return _compoundWidgetRef;
			}
			set
			{
				if (_compoundWidgetRef == value)
				{
					return;
				}
				_compoundWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("autoHideVertical")] 
		public CBool AutoHideVertical
		{
			get
			{
				if (_autoHideVertical == null)
				{
					_autoHideVertical = (CBool) CR2WTypeManager.Create("Bool", "autoHideVertical", cr2w, this);
				}
				return _autoHideVertical;
			}
			set
			{
				if (_autoHideVertical == value)
				{
					return;
				}
				_autoHideVertical = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scrollSpeedGamepad")] 
		public CFloat ScrollSpeedGamepad
		{
			get
			{
				if (_scrollSpeedGamepad == null)
				{
					_scrollSpeedGamepad = (CFloat) CR2WTypeManager.Create("Float", "scrollSpeedGamepad", cr2w, this);
				}
				return _scrollSpeedGamepad;
			}
			set
			{
				if (_scrollSpeedGamepad == value)
				{
					return;
				}
				_scrollSpeedGamepad = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("scrollSpeedMouse")] 
		public CFloat ScrollSpeedMouse
		{
			get
			{
				if (_scrollSpeedMouse == null)
				{
					_scrollSpeedMouse = (CFloat) CR2WTypeManager.Create("Float", "scrollSpeedMouse", cr2w, this);
				}
				return _scrollSpeedMouse;
			}
			set
			{
				if (_scrollSpeedMouse == value)
				{
					return;
				}
				_scrollSpeedMouse = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("direction")] 
		public CEnum<inkEScrollDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<inkEScrollDirection>) CR2WTypeManager.Create("inkEScrollDirection", "direction", cr2w, this);
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

		[Ordinal(9)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get
			{
				if (_useGlobalInput == null)
				{
					_useGlobalInput = (CBool) CR2WTypeManager.Create("Bool", "useGlobalInput", cr2w, this);
				}
				return _useGlobalInput;
			}
			set
			{
				if (_useGlobalInput == value)
				{
					return;
				}
				_useGlobalInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("position")] 
		public CFloat Position
		{
			get
			{
				if (_position == null)
				{
					_position = (CFloat) CR2WTypeManager.Create("Float", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scrollDelta")] 
		public CFloat ScrollDelta
		{
			get
			{
				if (_scrollDelta == null)
				{
					_scrollDelta = (CFloat) CR2WTypeManager.Create("Float", "scrollDelta", cr2w, this);
				}
				return _scrollDelta;
			}
			set
			{
				if (_scrollDelta == value)
				{
					return;
				}
				_scrollDelta = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("viewportSize")] 
		public Vector2 ViewportSize
		{
			get
			{
				if (_viewportSize == null)
				{
					_viewportSize = (Vector2) CR2WTypeManager.Create("Vector2", "viewportSize", cr2w, this);
				}
				return _viewportSize;
			}
			set
			{
				if (_viewportSize == value)
				{
					return;
				}
				_viewportSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("contentSize")] 
		public Vector2 ContentSize
		{
			get
			{
				if (_contentSize == null)
				{
					_contentSize = (Vector2) CR2WTypeManager.Create("Vector2", "contentSize", cr2w, this);
				}
				return _contentSize;
			}
			set
			{
				if (_contentSize == value)
				{
					return;
				}
				_contentSize = value;
				PropertySet(this);
			}
		}

		public inkScrollController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
