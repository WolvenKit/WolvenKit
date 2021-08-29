using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerPuppetPS : ScriptedPuppetPS
	{
		private KeyBindings _keybindigs;
		private CArray<gameuiMinigameProgramData> _availablePrograms;
		private CBool _hasAutoReveal;
		private CFloat _combatExitTimestamp;
		private CWeakHandle<gameIBlackboard> _minigameBB;

		[Ordinal(26)] 
		[RED("keybindigs")] 
		public KeyBindings Keybindigs
		{
			get => GetProperty(ref _keybindigs);
			set => SetProperty(ref _keybindigs, value);
		}

		[Ordinal(27)] 
		[RED("availablePrograms")] 
		public CArray<gameuiMinigameProgramData> AvailablePrograms
		{
			get => GetProperty(ref _availablePrograms);
			set => SetProperty(ref _availablePrograms, value);
		}

		[Ordinal(28)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetProperty(ref _hasAutoReveal);
			set => SetProperty(ref _hasAutoReveal, value);
		}

		[Ordinal(29)] 
		[RED("combatExitTimestamp")] 
		public CFloat CombatExitTimestamp
		{
			get => GetProperty(ref _combatExitTimestamp);
			set => SetProperty(ref _combatExitTimestamp, value);
		}

		[Ordinal(30)] 
		[RED("minigameBB")] 
		public CWeakHandle<gameIBlackboard> MinigameBB
		{
			get => GetProperty(ref _minigameBB);
			set => SetProperty(ref _minigameBB, value);
		}
	}
}
