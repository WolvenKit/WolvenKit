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
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}

		public AIbehaviorAttachToElevatorCommandTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
