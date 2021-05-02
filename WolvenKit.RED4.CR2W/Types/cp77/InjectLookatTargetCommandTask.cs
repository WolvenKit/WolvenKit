using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InjectLookatTargetCommandTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private wCHandle<AIInjectLookatTargetCommand> _currentCommand;
		private CFloat _activationTimeStamp;
		private CFloat _commandDuration;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetProperty(ref _inCommand);
			set => SetProperty(ref _inCommand, value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public wCHandle<AIInjectLookatTargetCommand> CurrentCommand
		{
			get => GetProperty(ref _currentCommand);
			set => SetProperty(ref _currentCommand, value);
		}

		[Ordinal(2)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetProperty(ref _activationTimeStamp);
			set => SetProperty(ref _activationTimeStamp, value);
		}

		[Ordinal(3)] 
		[RED("commandDuration")] 
		public CFloat CommandDuration
		{
			get => GetProperty(ref _commandDuration);
			set => SetProperty(ref _commandDuration, value);
		}

		public InjectLookatTargetCommandTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
