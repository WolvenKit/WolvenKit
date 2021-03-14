using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buffListGameController : gameuiHUDGameController
	{
		private inkHorizontalPanelWidgetReference _buffsList;
		private CUInt32 _bbBuffList;
		private CUInt32 _bbDeBuffList;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private CArray<gameuiBuffInfo> _buffDataList;
		private CArray<gameuiBuffInfo> _debuffDataList;
		private CArray<wCHandle<inkWidget>> _buffWidgets;
		private wCHandle<gameuiGameSystemUI> _uISystem;

		[Ordinal(9)] 
		[RED("buffsList")] 
		public inkHorizontalPanelWidgetReference BuffsList
		{
			get
			{
				if (_buffsList == null)
				{
					_buffsList = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "buffsList", cr2w, this);
				}
				return _buffsList;
			}
			set
			{
				if (_buffsList == value)
				{
					return;
				}
				_buffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bbBuffList")] 
		public CUInt32 BbBuffList
		{
			get
			{
				if (_bbBuffList == null)
				{
					_bbBuffList = (CUInt32) CR2WTypeManager.Create("Uint32", "bbBuffList", cr2w, this);
				}
				return _bbBuffList;
			}
			set
			{
				if (_bbBuffList == value)
				{
					return;
				}
				_bbBuffList = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bbDeBuffList")] 
		public CUInt32 BbDeBuffList
		{
			get
			{
				if (_bbDeBuffList == null)
				{
					_bbDeBuffList = (CUInt32) CR2WTypeManager.Create("Uint32", "bbDeBuffList", cr2w, this);
				}
				return _bbDeBuffList;
			}
			set
			{
				if (_bbDeBuffList == value)
				{
					return;
				}
				_bbDeBuffList = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get
			{
				if (_uiBlackboard == null)
				{
					_uiBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboard", cr2w, this);
				}
				return _uiBlackboard;
			}
			set
			{
				if (_uiBlackboard == value)
				{
					return;
				}
				_uiBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("buffDataList")] 
		public CArray<gameuiBuffInfo> BuffDataList
		{
			get
			{
				if (_buffDataList == null)
				{
					_buffDataList = (CArray<gameuiBuffInfo>) CR2WTypeManager.Create("array:gameuiBuffInfo", "buffDataList", cr2w, this);
				}
				return _buffDataList;
			}
			set
			{
				if (_buffDataList == value)
				{
					return;
				}
				_buffDataList = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("debuffDataList")] 
		public CArray<gameuiBuffInfo> DebuffDataList
		{
			get
			{
				if (_debuffDataList == null)
				{
					_debuffDataList = (CArray<gameuiBuffInfo>) CR2WTypeManager.Create("array:gameuiBuffInfo", "debuffDataList", cr2w, this);
				}
				return _debuffDataList;
			}
			set
			{
				if (_debuffDataList == value)
				{
					return;
				}
				_debuffDataList = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("buffWidgets")] 
		public CArray<wCHandle<inkWidget>> BuffWidgets
		{
			get
			{
				if (_buffWidgets == null)
				{
					_buffWidgets = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "buffWidgets", cr2w, this);
				}
				return _buffWidgets;
			}
			set
			{
				if (_buffWidgets == value)
				{
					return;
				}
				_buffWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("UISystem")] 
		public wCHandle<gameuiGameSystemUI> UISystem
		{
			get
			{
				if (_uISystem == null)
				{
					_uISystem = (wCHandle<gameuiGameSystemUI>) CR2WTypeManager.Create("whandle:gameuiGameSystemUI", "UISystem", cr2w, this);
				}
				return _uISystem;
			}
			set
			{
				if (_uISystem == value)
				{
					return;
				}
				_uISystem = value;
				PropertySet(this);
			}
		}

		public buffListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
