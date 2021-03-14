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
			get
			{
				if (_serversListCtrl == null)
				{
					_serversListCtrl = (wCHandle<inkListController>) CR2WTypeManager.Create("whandle:inkListController", "serversListCtrl", cr2w, this);
				}
				return _serversListCtrl;
			}
			set
			{
				if (_serversListCtrl == value)
				{
					return;
				}
				_serversListCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("NONE_CHOOSEN")] 
		public CInt32 NONE_CHOOSEN
		{
			get
			{
				if (_nONE_CHOOSEN == null)
				{
					_nONE_CHOOSEN = (CInt32) CR2WTypeManager.Create("Int32", "NONE_CHOOSEN", cr2w, this);
				}
				return _nONE_CHOOSEN;
			}
			set
			{
				if (_nONE_CHOOSEN == value)
				{
					return;
				}
				_nONE_CHOOSEN = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("curentlyChoosenServer")] 
		public CInt32 CurentlyChoosenServer
		{
			get
			{
				if (_curentlyChoosenServer == null)
				{
					_curentlyChoosenServer = (CInt32) CR2WTypeManager.Create("Int32", "curentlyChoosenServer", cr2w, this);
				}
				return _curentlyChoosenServer;
			}
			set
			{
				if (_curentlyChoosenServer == value)
				{
					return;
				}
				_curentlyChoosenServer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("LANStatusLabel")] 
		public wCHandle<inkTextWidget> LANStatusLabel
		{
			get
			{
				if (_lANStatusLabel == null)
				{
					_lANStatusLabel = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "LANStatusLabel", cr2w, this);
				}
				return _lANStatusLabel;
			}
			set
			{
				if (_lANStatusLabel == value)
				{
					return;
				}
				_lANStatusLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("WEBStatusLabel")] 
		public wCHandle<inkTextWidget> WEBStatusLabel
		{
			get
			{
				if (_wEBStatusLabel == null)
				{
					_wEBStatusLabel = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "WEBStatusLabel", cr2w, this);
				}
				return _wEBStatusLabel;
			}
			set
			{
				if (_wEBStatusLabel == value)
				{
					return;
				}
				_wEBStatusLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("c_onlineColor")] 
		public CColor C_onlineColor
		{
			get
			{
				if (_c_onlineColor == null)
				{
					_c_onlineColor = (CColor) CR2WTypeManager.Create("Color", "c_onlineColor", cr2w, this);
				}
				return _c_onlineColor;
			}
			set
			{
				if (_c_onlineColor == value)
				{
					return;
				}
				_c_onlineColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("c_offlineColor")] 
		public CColor C_offlineColor
		{
			get
			{
				if (_c_offlineColor == null)
				{
					_c_offlineColor = (CColor) CR2WTypeManager.Create("Color", "c_offlineColor", cr2w, this);
				}
				return _c_offlineColor;
			}
			set
			{
				if (_c_offlineColor == value)
				{
					return;
				}
				_c_offlineColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("token")] 
		public wCHandle<inkTextWidget> Token
		{
			get
			{
				if (_token == null)
				{
					_token = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "token", cr2w, this);
				}
				return _token;
			}
			set
			{
				if (_token == value)
				{
					return;
				}
				_token = value;
				PropertySet(this);
			}
		}

		public FindServersMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
