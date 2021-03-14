using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatCommand : AICommand
	{
		private CArray<AIBackgroundCombatStep> _steps;

		[Ordinal(4)] 
		[RED("steps")] 
		public CArray<AIBackgroundCombatStep> Steps
		{
			get
			{
				if (_steps == null)
				{
					_steps = (CArray<AIBackgroundCombatStep>) CR2WTypeManager.Create("array:AIBackgroundCombatStep", "steps", cr2w, this);
				}
				return _steps;
			}
			set
			{
				if (_steps == value)
				{
					return;
				}
				_steps = value;
				PropertySet(this);
			}
		}

		public AIBackgroundCombatCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
