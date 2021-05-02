using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netChargesWidgetGameController : gameuiHUDGameController
	{
		private CHandle<gameIBlackboard> _bbPlayerStats;
		private CUInt32 _bbPlayerEventId1;
		private CUInt32 _bbPlayerEventId2;
		private CUInt32 _bbPlayerEventId3;
		private wCHandle<inkTextWidget> _networkName;
		private wCHandle<inkTextWidget> _networkStatus;
		private CArray<wCHandle<inkCompoundWidget>> _chargesList;
		private CInt32 _chargesCurrent;
		private CInt32 _chargesMax;
		private CString _networkNameText;
		private CString _networkStatusText;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkHorizontalPanelWidget> _chargeList;

		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public CHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId1")] 
		public CUInt32 BbPlayerEventId1
		{
			get => GetProperty(ref _bbPlayerEventId1);
			set => SetProperty(ref _bbPlayerEventId1, value);
		}

		[Ordinal(11)] 
		[RED("bbPlayerEventId2")] 
		public CUInt32 BbPlayerEventId2
		{
			get => GetProperty(ref _bbPlayerEventId2);
			set => SetProperty(ref _bbPlayerEventId2, value);
		}

		[Ordinal(12)] 
		[RED("bbPlayerEventId3")] 
		public CUInt32 BbPlayerEventId3
		{
			get => GetProperty(ref _bbPlayerEventId3);
			set => SetProperty(ref _bbPlayerEventId3, value);
		}

		[Ordinal(13)] 
		[RED("networkName")] 
		public wCHandle<inkTextWidget> NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(14)] 
		[RED("networkStatus")] 
		public wCHandle<inkTextWidget> NetworkStatus
		{
			get => GetProperty(ref _networkStatus);
			set => SetProperty(ref _networkStatus, value);
		}

		[Ordinal(15)] 
		[RED("chargesList")] 
		public CArray<wCHandle<inkCompoundWidget>> ChargesList
		{
			get => GetProperty(ref _chargesList);
			set => SetProperty(ref _chargesList, value);
		}

		[Ordinal(16)] 
		[RED("chargesCurrent")] 
		public CInt32 ChargesCurrent
		{
			get => GetProperty(ref _chargesCurrent);
			set => SetProperty(ref _chargesCurrent, value);
		}

		[Ordinal(17)] 
		[RED("chargesMax")] 
		public CInt32 ChargesMax
		{
			get => GetProperty(ref _chargesMax);
			set => SetProperty(ref _chargesMax, value);
		}

		[Ordinal(18)] 
		[RED("networkNameText")] 
		public CString NetworkNameText
		{
			get => GetProperty(ref _networkNameText);
			set => SetProperty(ref _networkNameText, value);
		}

		[Ordinal(19)] 
		[RED("networkStatusText")] 
		public CString NetworkStatusText
		{
			get => GetProperty(ref _networkStatusText);
			set => SetProperty(ref _networkStatusText, value);
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(21)] 
		[RED("chargeList")] 
		public wCHandle<inkHorizontalPanelWidget> ChargeList
		{
			get => GetProperty(ref _chargeList);
			set => SetProperty(ref _chargeList, value);
		}

		public netChargesWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
