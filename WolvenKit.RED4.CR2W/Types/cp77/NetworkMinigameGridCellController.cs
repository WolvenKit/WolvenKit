using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameGridCellController : inkButtonController
	{
		private CellData _cellData;
		private wCHandle<NetworkMinigameGridController> _grid;
		private inkWidgetReference _slotsContainer;
		private wCHandle<NetworkMinigameElementController> _slotsContent;
		private CName _elementLibraryName;
		private HDRColor _defaultColor;

		[Ordinal(10)] 
		[RED("cellData")] 
		public CellData CellData
		{
			get
			{
				if (_cellData == null)
				{
					_cellData = (CellData) CR2WTypeManager.Create("CellData", "cellData", cr2w, this);
				}
				return _cellData;
			}
			set
			{
				if (_cellData == value)
				{
					return;
				}
				_cellData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("grid")] 
		public wCHandle<NetworkMinigameGridController> Grid
		{
			get
			{
				if (_grid == null)
				{
					_grid = (wCHandle<NetworkMinigameGridController>) CR2WTypeManager.Create("whandle:NetworkMinigameGridController", "grid", cr2w, this);
				}
				return _grid;
			}
			set
			{
				if (_grid == value)
				{
					return;
				}
				_grid = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("slotsContainer")] 
		public inkWidgetReference SlotsContainer
		{
			get
			{
				if (_slotsContainer == null)
				{
					_slotsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "slotsContainer", cr2w, this);
				}
				return _slotsContainer;
			}
			set
			{
				if (_slotsContainer == value)
				{
					return;
				}
				_slotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("slotsContent")] 
		public wCHandle<NetworkMinigameElementController> SlotsContent
		{
			get
			{
				if (_slotsContent == null)
				{
					_slotsContent = (wCHandle<NetworkMinigameElementController>) CR2WTypeManager.Create("whandle:NetworkMinigameElementController", "slotsContent", cr2w, this);
				}
				return _slotsContent;
			}
			set
			{
				if (_slotsContent == value)
				{
					return;
				}
				_slotsContent = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get
			{
				if (_elementLibraryName == null)
				{
					_elementLibraryName = (CName) CR2WTypeManager.Create("CName", "elementLibraryName", cr2w, this);
				}
				return _elementLibraryName;
			}
			set
			{
				if (_elementLibraryName == value)
				{
					return;
				}
				_elementLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get
			{
				if (_defaultColor == null)
				{
					_defaultColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "defaultColor", cr2w, this);
				}
				return _defaultColor;
			}
			set
			{
				if (_defaultColor == value)
				{
					return;
				}
				_defaultColor = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameGridCellController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
