using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FindServersMenuGameController : PreGameSubMenuGameController
	{
		private CWeakHandle<inkListController> _serversListCtrl;
		private CInt32 _nONE_CHOOSEN;
		private CInt32 _curentlyChoosenServer;
		private CWeakHandle<inkTextWidget> _lANStatusLabel;
		private CWeakHandle<inkTextWidget> _wEBStatusLabel;
		private CColor _c_onlineColor;
		private CColor _c_offlineColor;
		private CWeakHandle<inkTextWidget> _token;

		[Ordinal(3)] 
		[RED("serversListCtrl")] 
		public CWeakHandle<inkListController> ServersListCtrl
		{
			get => GetProperty(ref _serversListCtrl);
			set => SetProperty(ref _serversListCtrl, value);
		}

		[Ordinal(4)] 
		[RED("NONE_CHOOSEN")] 
		public CInt32 NONE_CHOOSEN
		{
			get => GetProperty(ref _nONE_CHOOSEN);
			set => SetProperty(ref _nONE_CHOOSEN, value);
		}

		[Ordinal(5)] 
		[RED("curentlyChoosenServer")] 
		public CInt32 CurentlyChoosenServer
		{
			get => GetProperty(ref _curentlyChoosenServer);
			set => SetProperty(ref _curentlyChoosenServer, value);
		}

		[Ordinal(6)] 
		[RED("LANStatusLabel")] 
		public CWeakHandle<inkTextWidget> LANStatusLabel
		{
			get => GetProperty(ref _lANStatusLabel);
			set => SetProperty(ref _lANStatusLabel, value);
		}

		[Ordinal(7)] 
		[RED("WEBStatusLabel")] 
		public CWeakHandle<inkTextWidget> WEBStatusLabel
		{
			get => GetProperty(ref _wEBStatusLabel);
			set => SetProperty(ref _wEBStatusLabel, value);
		}

		[Ordinal(8)] 
		[RED("c_onlineColor")] 
		public CColor C_onlineColor
		{
			get => GetProperty(ref _c_onlineColor);
			set => SetProperty(ref _c_onlineColor, value);
		}

		[Ordinal(9)] 
		[RED("c_offlineColor")] 
		public CColor C_offlineColor
		{
			get => GetProperty(ref _c_offlineColor);
			set => SetProperty(ref _c_offlineColor, value);
		}

		[Ordinal(10)] 
		[RED("token")] 
		public CWeakHandle<inkTextWidget> Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}
	}
}
