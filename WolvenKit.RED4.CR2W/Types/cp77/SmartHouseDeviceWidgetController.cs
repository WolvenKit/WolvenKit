using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHouseDeviceWidgetController : DeviceWidgetControllerBase
	{
		private wCHandle<inkWidget> _interiorManagerSlot;

		[Ordinal(10)] 
		[RED("interiorManagerSlot")] 
		public wCHandle<inkWidget> InteriorManagerSlot
		{
			get => GetProperty(ref _interiorManagerSlot);
			set => SetProperty(ref _interiorManagerSlot, value);
		}

		public SmartHouseDeviceWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
