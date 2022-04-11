using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerBBValuesIds : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouchActive")] 
		public gamebbScriptID_Int32 CrouchActive
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public PlayerCombatControllerBBValuesIds()
		{
			CrouchActive = new();
		}
	}
}
