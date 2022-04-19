using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questToggleCombatForPlayer_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("startCombat")] 
		public CBool StartCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questToggleCombatForPlayer_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
