using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AINPCCommandEvent : AIAIEvent
	{
		private CHandle<AICommand> _command;

		[Ordinal(2)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get
			{
				if (_command == null)
				{
					_command = (CHandle<AICommand>) CR2WTypeManager.Create("handle:AICommand", "command", cr2w, this);
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

		public AINPCCommandEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
