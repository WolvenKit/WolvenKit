using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPCControllerPS : ActivatedDeviceControllerPS
	{
		private ActivatedDeviceNPCSetup _activatedDeviceNPCSetup;

		[Ordinal(107)] 
		[RED("activatedDeviceNPCSetup")] 
		public ActivatedDeviceNPCSetup ActivatedDeviceNPCSetup
		{
			get
			{
				if (_activatedDeviceNPCSetup == null)
				{
					_activatedDeviceNPCSetup = (ActivatedDeviceNPCSetup) CR2WTypeManager.Create("ActivatedDeviceNPCSetup", "activatedDeviceNPCSetup", cr2w, this);
				}
				return _activatedDeviceNPCSetup;
			}
			set
			{
				if (_activatedDeviceNPCSetup == value)
				{
					return;
				}
				_activatedDeviceNPCSetup = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceNPCControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
