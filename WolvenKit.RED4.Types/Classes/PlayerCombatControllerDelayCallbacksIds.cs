using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerDelayCallbacksIds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouch")] 
		public gameDelayID Crouch
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public PlayerCombatControllerDelayCallbacksIds()
		{
			Crouch = new();
		}
	}
}
