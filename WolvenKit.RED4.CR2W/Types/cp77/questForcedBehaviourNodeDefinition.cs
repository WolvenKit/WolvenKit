using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForcedBehaviourNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _puppet;
		private CHandle<questForcedBehaviorReference> _tree;
		private CHandle<AIbehaviorParameterizedBehavior> _behavior;

		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(3)] 
		[RED("tree")] 
		public CHandle<questForcedBehaviorReference> Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}

		[Ordinal(4)] 
		[RED("behavior")] 
		public CHandle<AIbehaviorParameterizedBehavior> Behavior
		{
			get => GetProperty(ref _behavior);
			set => SetProperty(ref _behavior, value);
		}

		public questForcedBehaviourNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
