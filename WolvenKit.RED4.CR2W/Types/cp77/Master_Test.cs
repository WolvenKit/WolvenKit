using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Master_Test : gameObject
	{
		private CHandle<gameMasterDeviceComponent> _deviceComponent;

		[Ordinal(40)] 
		[RED("deviceComponent")] 
		public CHandle<gameMasterDeviceComponent> DeviceComponent
		{
			get => GetProperty(ref _deviceComponent);
			set => SetProperty(ref _deviceComponent, value);
		}

		public Master_Test(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
