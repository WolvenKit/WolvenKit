using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class drillMachine : gameweaponObject
	{
		private CHandle<RewireComponent> _rewireComponent;
		private wCHandle<gameObject> _player;
		private CHandle<DrillMachineScanManager> _scanManager;
		private CHandle<entIVisualComponent> _screen_postprocess;
		private CHandle<entIVisualComponent> _screen_backside;
		private CBool _isScanning;
		private CBool _isActive;
		private wCHandle<gameObject> _targetDevice;

		[Ordinal(57)] 
		[RED("rewireComponent")] 
		public CHandle<RewireComponent> RewireComponent
		{
			get
			{
				if (_rewireComponent == null)
				{
					_rewireComponent = (CHandle<RewireComponent>) CR2WTypeManager.Create("handle:RewireComponent", "rewireComponent", cr2w, this);
				}
				return _rewireComponent;
			}
			set
			{
				if (_rewireComponent == value)
				{
					return;
				}
				_rewireComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("scanManager")] 
		public CHandle<DrillMachineScanManager> ScanManager
		{
			get
			{
				if (_scanManager == null)
				{
					_scanManager = (CHandle<DrillMachineScanManager>) CR2WTypeManager.Create("handle:DrillMachineScanManager", "scanManager", cr2w, this);
				}
				return _scanManager;
			}
			set
			{
				if (_scanManager == value)
				{
					return;
				}
				_scanManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("screen_postprocess")] 
		public CHandle<entIVisualComponent> Screen_postprocess
		{
			get
			{
				if (_screen_postprocess == null)
				{
					_screen_postprocess = (CHandle<entIVisualComponent>) CR2WTypeManager.Create("handle:entIVisualComponent", "screen_postprocess", cr2w, this);
				}
				return _screen_postprocess;
			}
			set
			{
				if (_screen_postprocess == value)
				{
					return;
				}
				_screen_postprocess = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("screen_backside")] 
		public CHandle<entIVisualComponent> Screen_backside
		{
			get
			{
				if (_screen_backside == null)
				{
					_screen_backside = (CHandle<entIVisualComponent>) CR2WTypeManager.Create("handle:entIVisualComponent", "screen_backside", cr2w, this);
				}
				return _screen_backside;
			}
			set
			{
				if (_screen_backside == value)
				{
					return;
				}
				_screen_backside = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get
			{
				if (_isScanning == null)
				{
					_isScanning = (CBool) CR2WTypeManager.Create("Bool", "isScanning", cr2w, this);
				}
				return _isScanning;
			}
			set
			{
				if (_isScanning == value)
				{
					return;
				}
				_isScanning = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("targetDevice")] 
		public wCHandle<gameObject> TargetDevice
		{
			get
			{
				if (_targetDevice == null)
				{
					_targetDevice = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetDevice", cr2w, this);
				}
				return _targetDevice;
			}
			set
			{
				if (_targetDevice == value)
				{
					return;
				}
				_targetDevice = value;
				PropertySet(this);
			}
		}

		public drillMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
