using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkTextWidget> _doorStaturTextWidget;

		[Ordinal(16)] 
		[RED("doorStaturTextWidget")] 
		public wCHandle<inkTextWidget> DoorStaturTextWidget
		{
			get
			{
				if (_doorStaturTextWidget == null)
				{
					_doorStaturTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "doorStaturTextWidget", cr2w, this);
				}
				return _doorStaturTextWidget;
			}
			set
			{
				if (_doorStaturTextWidget == value)
				{
					return;
				}
				_doorStaturTextWidget = value;
				PropertySet(this);
			}
		}

		public DoorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
