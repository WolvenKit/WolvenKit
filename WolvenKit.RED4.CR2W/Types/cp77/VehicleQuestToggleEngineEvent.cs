using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestToggleEngineEvent : redEvent
	{
		private CBool _toggle;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get
			{
				if (_toggle == null)
				{
					_toggle = (CBool) CR2WTypeManager.Create("Bool", "toggle", cr2w, this);
				}
				return _toggle;
			}
			set
			{
				if (_toggle == value)
				{
					return;
				}
				_toggle = value;
				PropertySet(this);
			}
		}

		public VehicleQuestToggleEngineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
