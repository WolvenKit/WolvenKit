using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hubSelectorController : inkSelectorController
	{
		private inkWidgetReference _leftArrowWidget;
		private inkWidgetReference _rightArrowWidget;
		private inkHorizontalPanelWidgetReference _menuLabelHolder;
		private wCHandle<HubMenuLabelController> _selectedMenuLabel;
		private wCHandle<HubMenuLabelController> _previouslySelectedMenuLabel;
		private CArray<MenuData> _hubElementsData;
		private CInt32 _previousIndex;

		[Ordinal(15)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get
			{
				if (_leftArrowWidget == null)
				{
					_leftArrowWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftArrowWidget", cr2w, this);
				}
				return _leftArrowWidget;
			}
			set
			{
				if (_leftArrowWidget == value)
				{
					return;
				}
				_leftArrowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get
			{
				if (_rightArrowWidget == null)
				{
					_rightArrowWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightArrowWidget", cr2w, this);
				}
				return _rightArrowWidget;
			}
			set
			{
				if (_rightArrowWidget == value)
				{
					return;
				}
				_rightArrowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("menuLabelHolder")] 
		public inkHorizontalPanelWidgetReference MenuLabelHolder
		{
			get
			{
				if (_menuLabelHolder == null)
				{
					_menuLabelHolder = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "menuLabelHolder", cr2w, this);
				}
				return _menuLabelHolder;
			}
			set
			{
				if (_menuLabelHolder == value)
				{
					return;
				}
				_menuLabelHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("selectedMenuLabel")] 
		public wCHandle<HubMenuLabelController> SelectedMenuLabel
		{
			get
			{
				if (_selectedMenuLabel == null)
				{
					_selectedMenuLabel = (wCHandle<HubMenuLabelController>) CR2WTypeManager.Create("whandle:HubMenuLabelController", "selectedMenuLabel", cr2w, this);
				}
				return _selectedMenuLabel;
			}
			set
			{
				if (_selectedMenuLabel == value)
				{
					return;
				}
				_selectedMenuLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("previouslySelectedMenuLabel")] 
		public wCHandle<HubMenuLabelController> PreviouslySelectedMenuLabel
		{
			get
			{
				if (_previouslySelectedMenuLabel == null)
				{
					_previouslySelectedMenuLabel = (wCHandle<HubMenuLabelController>) CR2WTypeManager.Create("whandle:HubMenuLabelController", "previouslySelectedMenuLabel", cr2w, this);
				}
				return _previouslySelectedMenuLabel;
			}
			set
			{
				if (_previouslySelectedMenuLabel == value)
				{
					return;
				}
				_previouslySelectedMenuLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("hubElementsData")] 
		public CArray<MenuData> HubElementsData
		{
			get
			{
				if (_hubElementsData == null)
				{
					_hubElementsData = (CArray<MenuData>) CR2WTypeManager.Create("array:MenuData", "hubElementsData", cr2w, this);
				}
				return _hubElementsData;
			}
			set
			{
				if (_hubElementsData == value)
				{
					return;
				}
				_hubElementsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("previousIndex")] 
		public CInt32 PreviousIndex
		{
			get
			{
				if (_previousIndex == null)
				{
					_previousIndex = (CInt32) CR2WTypeManager.Create("Int32", "previousIndex", cr2w, this);
				}
				return _previousIndex;
			}
			set
			{
				if (_previousIndex == value)
				{
					return;
				}
				_previousIndex = value;
				PropertySet(this);
			}
		}

		public hubSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
