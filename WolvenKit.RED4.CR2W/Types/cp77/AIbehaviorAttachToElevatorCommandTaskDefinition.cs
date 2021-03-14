using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAttachToElevatorCommandTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _command;

		[Ordinal(1)] 
		[RED("command")] 
		public CHandle<AIArgumentMapping> Command
		{
			get
			{
				if (_command == null)
				{
					_command = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "command", cr2w, this);
				}
				return _command;
			}
			set
			{
				if (_command == value)
				{
					return;
				}
				_command = value;
				PropertySet(this);
			}
		}

		public AIbehaviorAttachToElevatorCommandTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
