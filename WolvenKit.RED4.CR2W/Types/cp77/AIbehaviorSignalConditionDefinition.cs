using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSignalConditionDefinition : AIbehaviorConditionDefinition
	{
		private CName _signalName;
		private CEnum<AIbehaviorSignalConditionModes> _mode;
		private CBool _tagSignal;

		[Ordinal(1)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get => GetProperty(ref _signalName);
			set => SetProperty(ref _signalName, value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<AIbehaviorSignalConditionModes> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(3)] 
		[RED("tagSignal")] 
		public CBool TagSignal
		{
			get => GetProperty(ref _tagSignal);
			set => SetProperty(ref _tagSignal, value);
		}

		public AIbehaviorSignalConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
