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
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<AICommandState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		public AINPCCommandStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
