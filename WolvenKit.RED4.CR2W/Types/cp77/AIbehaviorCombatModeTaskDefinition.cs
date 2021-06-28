using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCombatModeTaskDefinition : AIbehaviorTaskDefinition
	{
		private CEnum<AIbehaviorCombatModes> _mode;
		private CInt32 _priority;
		private CFloat _timeToLive;

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<AIbehaviorCombatModes> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(3)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetProperty(ref _timeToLive);
			set => SetProperty(ref _timeToLive, value);
		}

		public AIbehaviorCombatModeTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
