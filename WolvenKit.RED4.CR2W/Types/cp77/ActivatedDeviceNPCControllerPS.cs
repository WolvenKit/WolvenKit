using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPCControllerPS : ActivatedDeviceControllerPS
	{
		private ActivatedDeviceNPCSetup _activatedDeviceNPCSetup;

		[Ordinal(108)] 
		[RED("activatedDeviceNPCSetup")] 
		public ActivatedDeviceNPCSetup ActivatedDeviceNPCSetup
		{
			get => GetProperty(ref _activatedDeviceNPCSetup);
			set => SetProperty(ref _activatedDeviceNPCSetup, value);
		}

		public ActivatedDeviceNPCControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
