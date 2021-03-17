using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FindServersMenuGameController : PreGameSubMenuGameController
	{
		private wCHandle<inkListController> _serversListCtrl;
		private CInt32 _nONE_CHOOSEN;
		private CInt32 _curentlyChoosenServer;
		private wCHandle<inkTextWidget> _lANStatusLabel;
		private wCHandle<inkTextWidget> _wEBStatusLabel;
		private CColor _c_onlineColor;
		private CColor _c_offlineColor;
		private wCHandle<inkTextWidget> _token;

		[Ordinal(3)] 
		[RED("serversListCtrl")] 
		public wCHandle<inkListController> ServersListCtrl
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
		public wCHandle<inkTextWidget> LANStatusLabel
		{
			get => GetProperty(ref _lANStatusLabel);
			set => SetProperty(ref _lANStatusLabel, value);
		}

		[Ordinal(7)] 
		[RED("WEBStatusLabel")] 
		public wCHandle<inkTextWidget> WEBStatusLabel
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
		public wCHandle<inkTextWidget> Token
		{
			get => GetProperty(ref _token);
			set => SetProperty(ref _token, value);
		}

		public FindServersMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
