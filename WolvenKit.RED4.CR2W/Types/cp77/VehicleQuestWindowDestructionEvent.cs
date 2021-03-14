using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestWindowDestructionEvent : redEvent
	{
		private CName _windowName;
		private CEnum<vehicleQuestWindowDestruction> _window;

		[Ordinal(0)] 
		[RED("windowName")] 
		public CName WindowName
		{
			get
			{
				if (_windowName == null)
				{
					_windowName = (CName) CR2WTypeManager.Create("CName", "windowName", cr2w, this);
				}
				return _windowName;
			}
			set
			{
				if (_windowName == value)
				{
					return;
				}
				_windowName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("window")] 
		public CEnum<vehicleQuestWindowDestruction> Window
		{
			get
			{
				if (_window == null)
				{
					_window = (CEnum<vehicleQuestWindowDestruction>) CR2WTypeManager.Create("vehicleQuestWindowDestruction", "window", cr2w, this);
				}
				return _window;
			}
			set
			{
				if (_window == value)
				{
					return;
				}
				_window = value;
				PropertySet(this);
			}
		}

		public VehicleQuestWindowDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
