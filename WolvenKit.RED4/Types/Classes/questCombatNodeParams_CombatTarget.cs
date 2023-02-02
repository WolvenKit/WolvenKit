using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeParams_CombatTarget : questCombatNodeParams
	{
		[Ordinal(0)] 
		[RED("targetNode")] 
		public NodeRef TargetNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("targetPuppet")] 
		public gameEntityReference TargetPuppet
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCombatNodeParams_CombatTarget()
		{
			TargetPuppet = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
