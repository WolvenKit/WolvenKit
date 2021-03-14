using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceTakeControlDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _devicesChain;
		private gamebbScriptID_EntityID _activeDevice;
		private gamebbScriptID_Bool _isDeviceWorking;
		private gamebbScriptID_Bool _chainLocked;

		[Ordinal(0)] 
		[RED("DevicesChain")] 
		public gamebbScriptID_Variant DevicesChain
		{
			get
			{
				if (_devicesChain == null)
				{
					_devicesChain = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DevicesChain", cr2w, this);
				}
				return _devicesChain;
			}
			set
			{
				if (_devicesChain == value)
				{
					return;
				}
				_devicesChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ActiveDevice")] 
		public gamebbScriptID_EntityID ActiveDevice
		{
			get
			{
				if (_activeDevice == null)
				{
					_activeDevice = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "ActiveDevice", cr2w, this);
				}
				return _activeDevice;
			}
			set
			{
				if (_activeDevice == value)
				{
					return;
				}
				_activeDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("IsDeviceWorking")] 
		public gamebbScriptID_Bool IsDeviceWorking
		{
			get
			{
				if (_isDeviceWorking == null)
				{
					_isDeviceWorking = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsDeviceWorking", cr2w, this);
				}
				return _isDeviceWorking;
			}
			set
			{
				if (_isDeviceWorking == value)
				{
					return;
				}
				_isDeviceWorking = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ChainLocked")] 
		public gamebbScriptID_Bool ChainLocked
		{
			get
			{
				if (_chainLocked == null)
				{
					_chainLocked = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ChainLocked", cr2w, this);
				}
				return _chainLocked;
			}
			set
			{
				if (_chainLocked == value)
				{
					return;
				}
				_chainLocked = value;
				PropertySet(this);
			}
		}

		public DeviceTakeControlDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
