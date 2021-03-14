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
			get
			{
				if (_interiorManagerSlot == null)
				{
					_interiorManagerSlot = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "interiorManagerSlot", cr2w, this);
				}
				return _interiorManagerSlot;
			}
			set
			{
				if (_interiorManagerSlot == value)
				{
					return;
				}
				_interiorManagerSlot = value;
				PropertySet(this);
			}
		}

		public SmartHouseDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
