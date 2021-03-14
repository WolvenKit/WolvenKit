using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BoothModeGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _buttonRef;

		[Ordinal(2)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get
			{
				if (_buttonRef == null)
				{
					_buttonRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonRef", cr2w, this);
				}
				return _buttonRef;
			}
			set
			{
				if (_buttonRef == value)
				{
					return;
				}
				_buttonRef = value;
				PropertySet(this);
			}
		}

		public BoothModeGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
