using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPuppetPS : ScriptedPuppetPS
	{
		[Ordinal(33)] 
		[RED("keybindigs")] 
		public KeyBindings Keybindigs
		{
			get => GetPropertyValue<KeyBindings>();
			set => SetPropertyValue<KeyBindings>(value);
		}

		[Ordinal(34)] 
		[RED("availablePrograms")] 
		public CArray<gameuiMinigameProgramData> AvailablePrograms
		{
			get => GetPropertyValue<CArray<gameuiMinigameProgramData>>();
			set => SetPropertyValue<CArray<gameuiMinigameProgramData>>(value);
		}

		[Ordinal(35)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("combatExitTimestamp")] 
		public CFloat CombatExitTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("minigameBB")] 
		public CWeakHandle<gameIBlackboard> MinigameBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public PlayerPuppetPS()
		{
			Keybindigs = new();
			AvailablePrograms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
