using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareMainGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _mainViewRoot;
		private inkCompoundWidgetReference _cyberwareColumnLeft;
		private inkCompoundWidgetReference _cyberwareColumnRight;
		private inkCompoundWidgetReference _personalStatsList;
		private inkCompoundWidgetReference _attributesList;
		private inkCompoundWidgetReference _resistancesList;
		private inkWidgetReference _tooltipsManagerRef;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CName _resistanceView;
		private CName _statView;
		private inkMargin _toolTipOffset;
		private CArray<gameStatViewData> _rawStatsData;

		[Ordinal(2)] 
		[RED("MainViewRoot")] 
		public inkWidgetReference MainViewRoot
		{
			get => GetProperty(ref _mainViewRoot);
			set => SetProperty(ref _mainViewRoot, value);
		}

		[Ordinal(3)] 
		[RED("CyberwareColumnLeft")] 
		public inkCompoundWidgetReference CyberwareColumnLeft
		{
			get => GetProperty(ref _cyberwareColumnLeft);
			set => SetProperty(ref _cyberwareColumnLeft, value);
		}

		[Ordinal(4)] 
		[RED("CyberwareColumnRight")] 
		public inkCompoundWidgetReference CyberwareColumnRight
		{
			get => GetProperty(ref _cyberwareColumnRight);
			set => SetProperty(ref _cyberwareColumnRight, value);
		}

		[Ordinal(5)] 
		[RED("personalStatsList")] 
		public inkCompoundWidgetReference PersonalStatsList
		{
			get => GetProperty(ref _personalStatsList);
			set => SetProperty(ref _personalStatsList, value);
		}

		[Ordinal(6)] 
		[RED("attributesList")] 
		public inkCompoundWidgetReference AttributesList
		{
			get => GetProperty(ref _attributesList);
			set => SetProperty(ref _attributesList, value);
		}

		[Ordinal(7)] 
		[RED("resistancesList")] 
		public inkCompoundWidgetReference ResistancesList
		{
			get => GetProperty(ref _resistancesList);
			set => SetProperty(ref _resistancesList, value);
		}

		[Ordinal(8)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(9)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(10)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(11)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(12)] 
		[RED("resistanceView")] 
		public CName ResistanceView
		{
			get => GetProperty(ref _resistanceView);
			set => SetProperty(ref _resistanceView, value);
		}

		[Ordinal(13)] 
		[RED("statView")] 
		public CName StatView
		{
			get => GetProperty(ref _statView);
			set => SetProperty(ref _statView, value);
		}

		[Ordinal(14)] 
		[RED("toolTipOffset")] 
		public inkMargin ToolTipOffset
		{
			get => GetProperty(ref _toolTipOffset);
			set => SetProperty(ref _toolTipOffset, value);
		}

		[Ordinal(15)] 
		[RED("rawStatsData")] 
		public CArray<gameStatViewData> RawStatsData
		{
			get => GetProperty(ref _rawStatsData);
			set => SetProperty(ref _rawStatsData, value);
		}

		public CyberwareMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
