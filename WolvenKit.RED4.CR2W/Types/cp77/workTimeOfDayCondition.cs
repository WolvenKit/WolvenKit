using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTimeOfDayCondition : workIWorkspotCondition
	{
		private GameTime _activeAfter;
		private GameTime _activeUntil;

		[Ordinal(2)] 
		[RED("activeAfter")] 
		public GameTime ActiveAfter
		{
			get
			{
				if (_activeAfter == null)
				{
					_activeAfter = (GameTime) CR2WTypeManager.Create("GameTime", "activeAfter", cr2w, this);
				}
				return _activeAfter;
			}
			set
			{
				if (_activeAfter == value)
				{
					return;
				}
				_activeAfter = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("activeUntil")] 
		public GameTime ActiveUntil
		{
			get
			{
				if (_activeUntil == null)
				{
					_activeUntil = (GameTime) CR2WTypeManager.Create("GameTime", "activeUntil", cr2w, this);
				}
				return _activeUntil;
			}
			set
			{
				if (_activeUntil == value)
				{
					return;
				}
				_activeUntil = value;
				PropertySet(this);
			}
		}

		public workTimeOfDayCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
