using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerBehaviorDefinition : AIInterruptionHandlerDefinition
	{
		private CHandle<LibTreeINodeDefinition> _ai;
		private CBool _parallelActivation;
		private CBool _parallelExecution;
		private CBool _blockInterruption;

		[Ordinal(2)] 
		[RED("ai")] 
		public CHandle<LibTreeINodeDefinition> Ai
		{
			get => GetProperty(ref _ai);
			set => SetProperty(ref _ai, value);
		}

		[Ordinal(3)] 
		[RED("parallelActivation")] 
		public CBool ParallelActivation
		{
			get => GetProperty(ref _parallelActivation);
			set => SetProperty(ref _parallelActivation, value);
		}

		[Ordinal(4)] 
		[RED("parallelExecution")] 
		public CBool ParallelExecution
		{
			get => GetProperty(ref _parallelExecution);
			set => SetProperty(ref _parallelExecution, value);
		}

		[Ordinal(5)] 
		[RED("blockInterruption")] 
		public CBool BlockInterruption
		{
			get => GetProperty(ref _blockInterruption);
			set => SetProperty(ref _blockInterruption, value);
		}

		public AIInterruptionHandlerBehaviorDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
