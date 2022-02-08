using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questToggleCombatForPlayer_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("startCombat")] 
		public CBool StartCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
