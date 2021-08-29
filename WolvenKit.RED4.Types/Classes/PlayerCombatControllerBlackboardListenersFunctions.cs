using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerBlackboardListenersFunctions : RedBaseClass
	{
		private CName _crouchActive;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CName CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}
	}
}
