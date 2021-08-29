using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerDelayCallbacksIds : RedBaseClass
	{
		private gameDelayID _crouch;

		[Ordinal(0)] 
		[RED("crouch")] 
		public gameDelayID Crouch
		{
			get => GetProperty(ref _crouch);
			set => SetProperty(ref _crouch, value);
		}
	}
}
