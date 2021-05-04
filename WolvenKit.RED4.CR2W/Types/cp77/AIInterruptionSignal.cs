using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionSignal : CVariable
	{
		private CEnum<AIEInterruptionImportance> _importance;
		private CName _signal;

		[Ordinal(0)] 
		[RED("importance")] 
		public CEnum<AIEInterruptionImportance> Importance
		{
			get => GetProperty(ref _importance);
			set => SetProperty(ref _importance, value);
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get => GetProperty(ref _signal);
			set => SetProperty(ref _signal, value);
		}

		public AIInterruptionSignal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
