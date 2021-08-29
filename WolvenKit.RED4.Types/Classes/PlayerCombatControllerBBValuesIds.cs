using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerBBValuesIds : RedBaseClass
	{
		private gamebbScriptID_Int32 _crouchActive;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public gamebbScriptID_Int32 CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}
	}
}
