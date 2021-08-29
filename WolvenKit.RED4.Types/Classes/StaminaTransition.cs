using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StaminaTransition : DefaultTransition
	{
		private CBool _staminaChangeToggle;

		[Ordinal(0)] 
		[RED("staminaChangeToggle")] 
		public CBool StaminaChangeToggle
		{
			get => GetProperty(ref _staminaChangeToggle);
			set => SetProperty(ref _staminaChangeToggle, value);
		}
	}
}
