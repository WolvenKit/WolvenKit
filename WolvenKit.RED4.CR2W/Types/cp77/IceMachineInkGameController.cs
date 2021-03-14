using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _buttonContainer;

		[Ordinal(16)] 
		[RED("buttonContainer")] 
		public inkWidgetReference ButtonContainer
		{
			get
			{
				if (_buttonContainer == null)
				{
					_buttonContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonContainer", cr2w, this);
				}
				return _buttonContainer;
			}
			set
			{
				if (_buttonContainer == value)
				{
					return;
				}
				_buttonContainer = value;
				PropertySet(this);
			}
		}

		public IceMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
