using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerInvalidateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<PlayerCombatState> State
		{
			get => GetPropertyValue<CEnum<PlayerCombatState>>();
			set => SetPropertyValue<CEnum<PlayerCombatState>>(value);
		}
	}
}
