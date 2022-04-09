using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCombatNodeParams_RestrictMovementToArea : questCombatNodeParams
	{
		[Ordinal(0)] 
		[RED("area")] 
		public NodeRef Area
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public questCombatNodeParams_RestrictMovementToArea()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
