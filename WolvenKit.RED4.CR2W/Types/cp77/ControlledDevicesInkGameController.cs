using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ControlledDevicesInkGameController : gameuiWidgetGameController
	{
		private wCHandle<inkCanvasWidget> _rootWidget;
		private wCHandle<inkHorizontalPanelWidget> _devcesStackSlot;
		private wCHandle<inkTextWidget> _currentDeviceText;
		private CArray<SWidgetPackage> _controlledDevicesWidgetsData;
		private CUInt32 _isDeviceWorking_BBID;
		private CUInt32 _activeDevice_BBID;
		private CUInt32 _deviceChain_BBID;
		private CUInt32 _chainLocked_BBID;

		[Ordinal(2)] 
		[RED("rootWidget")] 
		public wCHandle<inkCanvasWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "rootWidget", cr2w, this);
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

		[Ordinal(3)] 
		[RED("devcesStackSlot")] 
		public wCHandle<inkHorizontalPanelWidget> DevcesStackSlot
		{
			get
			{
				if (_devcesStackSlot == null)
				{
					_devcesStackSlot = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "devcesStackSlot", cr2w, this);
				}
				return _devcesStackSlot;
			}
			set
			{
				if (_devcesStackSlot == value)
				{
					return;
				}
				_devcesStackSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentDeviceText")] 
		public wCHandle<inkTextWidget> CurrentDeviceText
		{
			get
			{
				if (_currentDeviceText == null)
				{
					_currentDeviceText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "currentDeviceText", cr2w, this);
				}
				return _currentDeviceText;
			}
			set
			{
				if (_currentDeviceText == value)
				{
					return;
				}
				_currentDeviceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("controlledDevicesWidgetsData")] 
		public CArray<SWidgetPackage> ControlledDevicesWidgetsData
		{
			get
			{
				if (_controlledDevicesWidgetsData == null)
				{
					_controlledDevicesWidgetsData = (CArray<SWidgetPackage>) CR2WTypeManager.Create("array:SWidgetPackage", "controlledDevicesWidgetsData", cr2w, this);
				}
				return _controlledDevicesWidgetsData;
			}
			set
			{
				if (_controlledDevicesWidgetsData == value)
				{
					return;
				}
				_controlledDevicesWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isDeviceWorking_BBID")] 
		public CUInt32 IsDeviceWorking_BBID
		{
			get
			{
				if (_isDeviceWorking_BBID == null)
				{
					_isDeviceWorking_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "isDeviceWorking_BBID", cr2w, this);
				}
				return _isDeviceWorking_BBID;
			}
			set
			{
				if (_isDeviceWorking_BBID == value)
				{
					return;
				}
				_isDeviceWorking_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("activeDevice_BBID")] 
		public CUInt32 ActiveDevice_BBID
		{
			get
			{
				if (_activeDevice_BBID == null)
				{
					_activeDevice_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "activeDevice_BBID", cr2w, this);
				}
				return _activeDevice_BBID;
			}
			set
			{
				if (_activeDevice_BBID == value)
				{
					return;
				}
				_activeDevice_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("deviceChain_BBID")] 
		public CUInt32 DeviceChain_BBID
		{
			get
			{
				if (_deviceChain_BBID == null)
				{
					_deviceChain_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "deviceChain_BBID", cr2w, this);
				}
				return _deviceChain_BBID;
			}
			set
			{
				if (_deviceChain_BBID == value)
				{
					return;
				}
				_deviceChain_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("chainLocked_BBID")] 
		public CUInt32 ChainLocked_BBID
		{
			get
			{
				if (_chainLocked_BBID == null)
				{
					_chainLocked_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "chainLocked_BBID", cr2w, this);
				}
				return _chainLocked_BBID;
			}
			set
			{
				if (_chainLocked_BBID == value)
				{
					return;
				}
				_chainLocked_BBID = value;
				PropertySet(this);
			}
		}

		public ControlledDevicesInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
