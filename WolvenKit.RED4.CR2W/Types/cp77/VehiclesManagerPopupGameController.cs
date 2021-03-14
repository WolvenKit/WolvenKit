using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerPopupGameController : BaseModalListPopupGameController
	{
		private inkImageWidgetReference _icon;
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _scrollControllerWidget;
		private CHandle<VehiclesManagerDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private wCHandle<inkScrollController> _scrollController;

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get
			{
				if (_scrollArea == null)
				{
					_scrollArea = (inkScrollAreaWidgetReference) CR2WTypeManager.Create("inkScrollAreaWidgetReference", "scrollArea", cr2w, this);
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

		[Ordinal(13)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get
			{
				if (_scrollControllerWidget == null)
				{
					_scrollControllerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "scrollControllerWidget", cr2w, this);
				}
				return _scrollControllerWidget;
			}
			set
			{
				if (_scrollControllerWidget == value)
				{
					return;
				}
				_scrollControllerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("dataView")] 
		public CHandle<VehiclesManagerDataView> DataView
		{
			get
			{
				if (_dataView == null)
				{
					_dataView = (CHandle<VehiclesManagerDataView>) CR2WTypeManager.Create("handle:VehiclesManagerDataView", "dataView", cr2w, this);
				}
				return _dataView;
			}
			set
			{
				if (_dataView == value)
				{
					return;
				}
				_dataView = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get
			{
				if (_dataSource == null)
				{
					_dataSource = (CHandle<inkScriptableDataSourceWrapper>) CR2WTypeManager.Create("handle:inkScriptableDataSourceWrapper", "dataSource", cr2w, this);
				}
				return _dataSource;
			}
			set
			{
				if (_dataSource == value)
				{
					return;
				}
				_dataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("quickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get
			{
				if (_quickSlotsManager == null)
				{
					_quickSlotsManager = (wCHandle<QuickSlotsManager>) CR2WTypeManager.Create("whandle:QuickSlotsManager", "quickSlotsManager", cr2w, this);
				}
				return _quickSlotsManager;
			}
			set
			{
				if (_quickSlotsManager == value)
				{
					return;
				}
				_quickSlotsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get
			{
				if (_scrollController == null)
				{
					_scrollController = (wCHandle<inkScrollController>) CR2WTypeManager.Create("whandle:inkScrollController", "scrollController", cr2w, this);
				}
				return _scrollController;
			}
			set
			{
				if (_scrollController == value)
				{
					return;
				}
				_scrollController = value;
				PropertySet(this);
			}
		}

		public VehiclesManagerPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
