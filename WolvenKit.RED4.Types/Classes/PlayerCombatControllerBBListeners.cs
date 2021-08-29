using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerBBListeners : RedBaseClass
	{
		private CHandle<redCallbackObject> _crouchActive;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CHandle<redCallbackObject> CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}
	}
}
