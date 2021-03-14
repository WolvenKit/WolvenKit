using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AINPCCommandStateEvent : redEvent
	{
		private CHandle<AICommand> _command;
		private CEnum<AICommandState> _newState;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<AICommandState> NewState
		{
			get
			{
				if (_newState == null)
				{
					_newState = (CEnum<AICommandState>) CR2WTypeManager.Create("AICommandState", "newState", cr2w, this);
				}
				return _newState;
			}
			set
			{
				if (_newState == value)
				{
					return;
				}
				_newState = value;
				PropertySet(this);
			}
		}

		public AINPCCommandStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
