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
			get => GetProperty(ref _cellData);
			set => SetProperty(ref _cellData, value);
		}

		[Ordinal(11)] 
		[RED("grid")] 
		public wCHandle<NetworkMinigameGridController> Grid
		{
			get => GetProperty(ref _grid);
			set => SetProperty(ref _grid, value);
		}

		[Ordinal(12)] 
		[RED("slotsContainer")] 
		public inkWidgetReference SlotsContainer
		{
			get => GetProperty(ref _slotsContainer);
			set => SetProperty(ref _slotsContainer, value);
		}

		[Ordinal(13)] 
		[RED("slotsContent")] 
		public wCHandle<NetworkMinigameElementController> SlotsContent
		{
			get => GetProperty(ref _slotsContent);
			set => SetProperty(ref _slotsContent, value);
		}

		[Ordinal(14)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetProperty(ref _elementLibraryName);
			set => SetProperty(ref _elementLibraryName, value);
		}

		[Ordinal(15)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		public NetworkMinigameGridCellController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
