using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerPuppetPS : ScriptedPuppetPS
	{
		[Ordinal(35)] 
		[RED("keybindigs")] 
		public KeyBindings Keybindigs
		{
			get => GetPropertyValue<KeyBindings>();
			set => SetPropertyValue<KeyBindings>(value);
		}

		[Ordinal(36)] 
		[RED("availablePrograms")] 
		public CArray<gameuiMinigameProgramData> AvailablePrograms
		{
			get => GetPropertyValue<CArray<gameuiMinigameProgramData>>();
			set => SetPropertyValue<CArray<gameuiMinigameProgramData>>(value);
		}

		[Ordinal(37)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("combatExitTimestamp")] 
		public CFloat CombatExitTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("isInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("pocketRadioStation")] 
		public CInt32 PocketRadioStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("permanentHealthBonus")] 
		public CFloat PermanentHealthBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("permanentStaminaBonus")] 
		public CFloat PermanentStaminaBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("permanentMemoryBonus")] 
		public CFloat PermanentMemoryBonus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("minigameBB")] 
		public CWeakHandle<gameIBlackboard> MinigameBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public PlayerPuppetPS()
		{
			Keybindigs = new KeyBindings();
			AvailablePrograms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
