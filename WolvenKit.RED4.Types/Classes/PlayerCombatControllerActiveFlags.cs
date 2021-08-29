using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerActiveFlags : RedBaseClass
	{
		private CBool _crouchActive;
		private CBool _crouchTimerPassed;
		private CBool _squadInCombat;
		private CBool _usingJhonnyReplacer;
		private CBool _usingQuickHack;

		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CBool CrouchActive
		{
			get => GetProperty(ref _crouchActive);
			set => SetProperty(ref _crouchActive, value);
		}

		[Ordinal(1)] 
		[RED("crouchTimerPassed")] 
		public CBool CrouchTimerPassed
		{
			get => GetProperty(ref _crouchTimerPassed);
			set => SetProperty(ref _crouchTimerPassed, value);
		}

		[Ordinal(2)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetProperty(ref _squadInCombat);
			set => SetProperty(ref _squadInCombat, value);
		}

		[Ordinal(3)] 
		[RED("usingJhonnyReplacer")] 
		public CBool UsingJhonnyReplacer
		{
			get => GetProperty(ref _usingJhonnyReplacer);
			set => SetProperty(ref _usingJhonnyReplacer, value);
		}

		[Ordinal(4)] 
		[RED("usingQuickHack")] 
		public CBool UsingQuickHack
		{
			get => GetProperty(ref _usingQuickHack);
			set => SetProperty(ref _usingQuickHack, value);
		}
	}
}
