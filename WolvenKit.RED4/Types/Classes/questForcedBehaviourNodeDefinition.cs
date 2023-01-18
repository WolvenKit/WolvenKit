using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questForcedBehaviourNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("tree")] 
		public CHandle<questForcedBehaviorReference> Tree
		{
			get => GetPropertyValue<CHandle<questForcedBehaviorReference>>();
			set => SetPropertyValue<CHandle<questForcedBehaviorReference>>(value);
		}

		[Ordinal(4)] 
		[RED("behavior")] 
		public CHandle<AIbehaviorParameterizedBehavior> Behavior
		{
			get => GetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>();
			set => SetPropertyValue<CHandle<AIbehaviorParameterizedBehavior>>(value);
		}

		public questForcedBehaviourNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Puppet = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
