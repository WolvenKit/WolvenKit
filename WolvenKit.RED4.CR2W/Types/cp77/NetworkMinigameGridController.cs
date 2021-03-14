using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameGridController : inkWidgetLogicController
	{
		private inkWidgetReference _gridContainer;
		private inkWidgetReference _horizontalHoverHighlight;
		private inkWidgetReference _horizontalCurrentHighlight;
		private inkWidgetReference _verticalHoverHighlight;
		private inkWidgetReference _verticalCurrentHighlight;
		private Vector2 _gridVisualOffset;
		private CName _gridCellLibraryName;
		private CArray<CellData> _gridData;
		private CellData _lastSelected;
		private Vector2 _currentActivePosition;
		private CBool _isHorizontalHighlight;
		private CellData _lastHighlighted;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _animHighlightProxy;
		private CBool _firstBoot;
		private CBool _isHorizontal;

		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkWidgetReference GridContainer
		{
			get
			{
				if (_gridContainer == null)
				{
					_gridContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gridContainer", cr2w, this);
				}
				return _gridContainer;
			}
			set
			{
				if (_gridContainer == value)
				{
					return;
				}
				_gridContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("horizontalHoverHighlight")] 
		public inkWidgetReference HorizontalHoverHighlight
		{
			get
			{
				if (_horizontalHoverHighlight == null)
				{
					_horizontalHoverHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "horizontalHoverHighlight", cr2w, this);
				}
				return _horizontalHoverHighlight;
			}
			set
			{
				if (_horizontalHoverHighlight == value)
				{
					return;
				}
				_horizontalHoverHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("horizontalCurrentHighlight")] 
		public inkWidgetReference HorizontalCurrentHighlight
		{
			get
			{
				if (_horizontalCurrentHighlight == null)
				{
					_horizontalCurrentHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "horizontalCurrentHighlight", cr2w, this);
				}
				return _horizontalCurrentHighlight;
			}
			set
			{
				if (_horizontalCurrentHighlight == value)
				{
					return;
				}
				_horizontalCurrentHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("verticalHoverHighlight")] 
		public inkWidgetReference VerticalHoverHighlight
		{
			get
			{
				if (_verticalHoverHighlight == null)
				{
					_verticalHoverHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "verticalHoverHighlight", cr2w, this);
				}
				return _verticalHoverHighlight;
			}
			set
			{
				if (_verticalHoverHighlight == value)
				{
					return;
				}
				_verticalHoverHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("verticalCurrentHighlight")] 
		public inkWidgetReference VerticalCurrentHighlight
		{
			get
			{
				if (_verticalCurrentHighlight == null)
				{
					_verticalCurrentHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "verticalCurrentHighlight", cr2w, this);
				}
				return _verticalCurrentHighlight;
			}
			set
			{
				if (_verticalCurrentHighlight == value)
				{
					return;
				}
				_verticalCurrentHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gridVisualOffset")] 
		public Vector2 GridVisualOffset
		{
			get
			{
				if (_gridVisualOffset == null)
				{
					_gridVisualOffset = (Vector2) CR2WTypeManager.Create("Vector2", "gridVisualOffset", cr2w, this);
				}
				return _gridVisualOffset;
			}
			set
			{
				if (_gridVisualOffset == value)
				{
					return;
				}
				_gridVisualOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gridCellLibraryName")] 
		public CName GridCellLibraryName
		{
			get
			{
				if (_gridCellLibraryName == null)
				{
					_gridCellLibraryName = (CName) CR2WTypeManager.Create("CName", "gridCellLibraryName", cr2w, this);
				}
				return _gridCellLibraryName;
			}
			set
			{
				if (_gridCellLibraryName == value)
				{
					return;
				}
				_gridCellLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gridData")] 
		public CArray<CellData> GridData
		{
			get
			{
				if (_gridData == null)
				{
					_gridData = (CArray<CellData>) CR2WTypeManager.Create("array:CellData", "gridData", cr2w, this);
				}
				return _gridData;
			}
			set
			{
				if (_gridData == value)
				{
					return;
				}
				_gridData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastSelected")] 
		public CellData LastSelected
		{
			get
			{
				if (_lastSelected == null)
				{
					_lastSelected = (CellData) CR2WTypeManager.Create("CellData", "lastSelected", cr2w, this);
				}
				return _lastSelected;
			}
			set
			{
				if (_lastSelected == value)
				{
					return;
				}
				_lastSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentActivePosition")] 
		public Vector2 CurrentActivePosition
		{
			get
			{
				if (_currentActivePosition == null)
				{
					_currentActivePosition = (Vector2) CR2WTypeManager.Create("Vector2", "currentActivePosition", cr2w, this);
				}
				return _currentActivePosition;
			}
			set
			{
				if (_currentActivePosition == value)
				{
					return;
				}
				_currentActivePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isHorizontalHighlight")] 
		public CBool IsHorizontalHighlight
		{
			get
			{
				if (_isHorizontalHighlight == null)
				{
					_isHorizontalHighlight = (CBool) CR2WTypeManager.Create("Bool", "isHorizontalHighlight", cr2w, this);
				}
				return _isHorizontalHighlight;
			}
			set
			{
				if (_isHorizontalHighlight == value)
				{
					return;
				}
				_isHorizontalHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lastHighlighted")] 
		public CellData LastHighlighted
		{
			get
			{
				if (_lastHighlighted == null)
				{
					_lastHighlighted = (CellData) CR2WTypeManager.Create("CellData", "lastHighlighted", cr2w, this);
				}
				return _lastHighlighted;
			}
			set
			{
				if (_lastHighlighted == value)
				{
					return;
				}
				_lastHighlighted = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animHighlightProxy")] 
		public CHandle<inkanimProxy> AnimHighlightProxy
		{
			get
			{
				if (_animHighlightProxy == null)
				{
					_animHighlightProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animHighlightProxy", cr2w, this);
				}
				return _animHighlightProxy;
			}
			set
			{
				if (_animHighlightProxy == value)
				{
					return;
				}
				_animHighlightProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("firstBoot")] 
		public CBool FirstBoot
		{
			get
			{
				if (_firstBoot == null)
				{
					_firstBoot = (CBool) CR2WTypeManager.Create("Bool", "firstBoot", cr2w, this);
				}
				return _firstBoot;
			}
			set
			{
				if (_firstBoot == value)
				{
					return;
				}
				_firstBoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isHorizontal")] 
		public CBool IsHorizontal
		{
			get
			{
				if (_isHorizontal == null)
				{
					_isHorizontal = (CBool) CR2WTypeManager.Create("Bool", "isHorizontal", cr2w, this);
				}
				return _isHorizontal;
			}
			set
			{
				if (_isHorizontal == value)
				{
					return;
				}
				_isHorizontal = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameGridController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
