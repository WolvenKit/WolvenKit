using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeathDirectionEvent : redEvent
	{
		private CEnum<gameeventsDeathDirection> _direction;

		[Ordinal(0)] 
		[RED("direction")] 
		public CEnum<gameeventsDeathDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<gameeventsDeathDirection>) CR2WTypeManager.Create("gameeventsDeathDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public gameeventsDeathDirectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
