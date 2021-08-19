using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buffListGameController : gameuiHUDGameController
	{
		private inkHorizontalPanelWidgetReference _buffsList;
		private CHandle<redCallbackObject> _bbBuffList;
		private CHandle<redCallbackObject> _bbDeBuffList;
		private wCHandle<gameIBlackboard> _uiBlackboard;
		private CArray<gameuiBuffInfo> _buffDataList;
		private CArray<gameuiBuffInfo> _debuffDataList;
		private CArray<wCHandle<inkWidget>> _buffWidgets;
		private wCHandle<gameuiGameSystemUI> _uISystem;
		private CInt32 _pendingRequests;

		[Ordinal(9)] 
		[RED("buffsList")] 
		public inkHorizontalPanelWidgetReference BuffsList
		{
			get => GetProperty(ref _buffsList);
			set => SetProperty(ref _buffsList, value);
		}

		[Ordinal(10)] 
		[RED("bbBuffList")] 
		public CHandle<redCallbackObject> BbBuffList
		{
			get => GetProperty(ref _bbBuffList);
			set => SetProperty(ref _bbBuffList, value);
		}

		[Ordinal(11)] 
		[RED("bbDeBuffList")] 
		public CHandle<redCallbackObject> BbDeBuffList
		{
			get => GetProperty(ref _bbDeBuffList);
			set => SetProperty(ref _bbDeBuffList, value);
		}

		[Ordinal(12)] 
		[RED("uiBlackboard")] 
		public wCHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(13)] 
		[RED("buffDataList")] 
		public CArray<gameuiBuffInfo> BuffDataList
		{
			get => GetProperty(ref _buffDataList);
			set => SetProperty(ref _buffDataList, value);
		}

		[Ordinal(14)] 
		[RED("debuffDataList")] 
		public CArray<gameuiBuffInfo> DebuffDataList
		{
			get => GetProperty(ref _debuffDataList);
			set => SetProperty(ref _debuffDataList, value);
		}

		[Ordinal(15)] 
		[RED("buffWidgets")] 
		public CArray<wCHandle<inkWidget>> BuffWidgets
		{
			get => GetProperty(ref _buffWidgets);
			set => SetProperty(ref _buffWidgets, value);
		}

		[Ordinal(16)] 
		[RED("UISystem")] 
		public wCHandle<gameuiGameSystemUI> UISystem
		{
			get => GetProperty(ref _uISystem);
			set => SetProperty(ref _uISystem, value);
		}

		[Ordinal(17)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetProperty(ref _pendingRequests);
			set => SetProperty(ref _pendingRequests, value);
		}

		public buffListGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
