using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleLightEvent : redEvent
	{
		private CBool _toggle;
		private CBool _loop;

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

		[Ordinal(1)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		public ToggleLightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
