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
			get
			{
				if (_bbPlayerStats == null)
				{
					_bbPlayerStats = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bbPlayerStats", cr2w, this);
				}
				return _bbPlayerStats;
			}
			set
			{
				if (_bbPlayerStats == value)
				{
					return;
				}
				_bbPlayerStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId1")] 
		public CUInt32 BbPlayerEventId1
		{
			get
			{
				if (_bbPlayerEventId1 == null)
				{
					_bbPlayerEventId1 = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerEventId1", cr2w, this);
				}
				return _bbPlayerEventId1;
			}
			set
			{
				if (_bbPlayerEventId1 == value)
				{
					return;
				}
				_bbPlayerEventId1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bbPlayerEventId2")] 
		public CUInt32 BbPlayerEventId2
		{
			get
			{
				if (_bbPlayerEventId2 == null)
				{
					_bbPlayerEventId2 = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerEventId2", cr2w, this);
				}
				return _bbPlayerEventId2;
			}
			set
			{
				if (_bbPlayerEventId2 == value)
				{
					return;
				}
				_bbPlayerEventId2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("bbPlayerEventId3")] 
		public CUInt32 BbPlayerEventId3
		{
			get
			{
				if (_bbPlayerEventId3 == null)
				{
					_bbPlayerEventId3 = (CUInt32) CR2WTypeManager.Create("Uint32", "bbPlayerEventId3", cr2w, this);
				}
				return _bbPlayerEventId3;
			}
			set
			{
				if (_bbPlayerEventId3 == value)
				{
					return;
				}
				_bbPlayerEventId3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("networkName")] 
		public wCHandle<inkTextWidget> NetworkName
		{
			get
			{
				if (_networkName == null)
				{
					_networkName = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "networkName", cr2w, this);
				}
				return _networkName;
			}
			set
			{
				if (_networkName == value)
				{
					return;
				}
				_networkName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("networkStatus")] 
		public wCHandle<inkTextWidget> NetworkStatus
		{
			get
			{
				if (_networkStatus == null)
				{
					_networkStatus = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "networkStatus", cr2w, this);
				}
				return _networkStatus;
			}
			set
			{
				if (_networkStatus == value)
				{
					return;
				}
				_networkStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("chargesList")] 
		public CArray<wCHandle<inkCompoundWidget>> ChargesList
		{
			get
			{
				if (_chargesList == null)
				{
					_chargesList = (CArray<wCHandle<inkCompoundWidget>>) CR2WTypeManager.Create("array:whandle:inkCompoundWidget", "chargesList", cr2w, this);
				}
				return _chargesList;
			}
			set
			{
				if (_chargesList == value)
				{
					return;
				}
				_chargesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("chargesCurrent")] 
		public CInt32 ChargesCurrent
		{
			get
			{
				if (_chargesCurrent == null)
				{
					_chargesCurrent = (CInt32) CR2WTypeManager.Create("Int32", "chargesCurrent", cr2w, this);
				}
				return _chargesCurrent;
			}
			set
			{
				if (_chargesCurrent == value)
				{
					return;
				}
				_chargesCurrent = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("chargesMax")] 
		public CInt32 ChargesMax
		{
			get
			{
				if (_chargesMax == null)
				{
					_chargesMax = (CInt32) CR2WTypeManager.Create("Int32", "chargesMax", cr2w, this);
				}
				return _chargesMax;
			}
			set
			{
				if (_chargesMax == value)
				{
					return;
				}
				_chargesMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("networkNameText")] 
		public CString NetworkNameText
		{
			get
			{
				if (_networkNameText == null)
				{
					_networkNameText = (CString) CR2WTypeManager.Create("String", "networkNameText", cr2w, this);
				}
				return _networkNameText;
			}
			set
			{
				if (_networkNameText == value)
				{
					return;
				}
				_networkNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("networkStatusText")] 
		public CString NetworkStatusText
		{
			get
			{
				if (_networkStatusText == null)
				{
					_networkStatusText = (CString) CR2WTypeManager.Create("String", "networkStatusText", cr2w, this);
				}
				return _networkStatusText;
			}
			set
			{
				if (_networkStatusText == value)
				{
					return;
				}
				_networkStatusText = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("chargeList")] 
		public wCHandle<inkHorizontalPanelWidget> ChargeList
		{
			get
			{
				if (_chargeList == null)
				{
					_chargeList = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "chargeList", cr2w, this);
				}
				return _chargeList;
			}
			set
			{
				if (_chargeList == value)
				{
					return;
				}
				_chargeList = value;
				PropertySet(this);
			}
		}

		public netChargesWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
