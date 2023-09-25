using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get => GetPropertyValue<CArray<redResourceReferenceScriptToken>>();
			set => SetPropertyValue<CArray<redResourceReferenceScriptToken>>(value);
		}

		[Ordinal(108)] 
		[RED("DEBUG_enableArcadeMinigames")] 
		public CBool DEBUG_enableArcadeMinigames
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("minigame")] 
		public CEnum<ArcadeMinigame> Minigame
		{
			get => GetPropertyValue<CEnum<ArcadeMinigame>>();
			set => SetPropertyValue<CEnum<ArcadeMinigame>>(value);
		}

		[Ordinal(110)] 
		[RED("combatStateListener")] 
		public CHandle<redCallbackObject> CombatStateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ArcadeMachineControllerPS()
		{
			DeviceName = "LocKey#1635";
			TweakDBRecord = "Devices.ArcadeMachine";
			TweakDBDescriptionRecord = 143953089827;
			GameVideosPaths = new();
			DEBUG_enableArcadeMinigames = true;
			Minigame = Enums.ArcadeMinigame.INVALID;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
