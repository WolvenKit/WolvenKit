using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowControllerPS : DoorControllerPS
	{
		private CHandle<EngDemoContainer> _windowSkillChecks;

		[Ordinal(113)] 
		[RED("windowSkillChecks")] 
		public CHandle<EngDemoContainer> WindowSkillChecks
		{
			get
			{
				if (_windowSkillChecks == null)
				{
					_windowSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "windowSkillChecks", cr2w, this);
				}
				return _windowSkillChecks;
			}
			set
			{
				if (_windowSkillChecks == value)
				{
					return;
				}
				_windowSkillChecks = value;
				PropertySet(this);
			}
		}

		public WindowControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
