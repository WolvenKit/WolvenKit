using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDecisionDefinition : AICTreeNodeCompositeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _child;
		private CArray<CHandle<LibTreeINodeDefinition>> _expressions;
		private AIInterruptionSignal _interruption;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}

		[Ordinal(1)] 
		[RED("expressions")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Expressions
		{
			get => GetProperty(ref _expressions);
			set => SetProperty(ref _expressions, value);
		}

		[Ordinal(2)] 
		[RED("interruption")] 
		public AIInterruptionSignal Interruption
		{
			get => GetProperty(ref _interruption);
			set => SetProperty(ref _interruption, value);
		}

		public AICTreeNodeDecisionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
