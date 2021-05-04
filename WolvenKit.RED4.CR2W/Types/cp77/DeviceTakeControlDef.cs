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
			get => GetProperty(ref _devicesChain);
			set => SetProperty(ref _devicesChain, value);
		}

		[Ordinal(1)] 
		[RED("ActiveDevice")] 
		public gamebbScriptID_EntityID ActiveDevice
		{
			get => GetProperty(ref _activeDevice);
			set => SetProperty(ref _activeDevice, value);
		}

		[Ordinal(2)] 
		[RED("IsDeviceWorking")] 
		public gamebbScriptID_Bool IsDeviceWorking
		{
			get => GetProperty(ref _isDeviceWorking);
			set => SetProperty(ref _isDeviceWorking, value);
		}

		[Ordinal(3)] 
		[RED("ChainLocked")] 
		public gamebbScriptID_Bool ChainLocked
		{
			get => GetProperty(ref _chainLocked);
			set => SetProperty(ref _chainLocked, value);
		}

		public DeviceTakeControlDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
