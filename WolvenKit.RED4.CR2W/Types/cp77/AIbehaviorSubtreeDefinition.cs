using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		private CHandle<AIbehaviorParameterizedBehavior> _tree;

		[Ordinal(2)] 
		[RED("tree")] 
		public CHandle<AIbehaviorParameterizedBehavior> Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}

		public AIbehaviorSubtreeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
