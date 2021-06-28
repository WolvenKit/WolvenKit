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
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		public AINPCCommandEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
