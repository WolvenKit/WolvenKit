using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerBBIds : RedBaseClass
	{
		private CHandle<gamebbScriptDefinition> _crouchActive;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CHandle<gamebbScriptDefinition> CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}
	}
}
