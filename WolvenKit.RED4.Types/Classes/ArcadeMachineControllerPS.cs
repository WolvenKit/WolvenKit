using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get => GetPropertyValue<CArray<redResourceReferenceScriptToken>>();
			set => SetPropertyValue<CArray<redResourceReferenceScriptToken>>(value);
		}

		[Ordinal(105)] 
		[RED("arcadeMinigame")] 
		public CEnum<ArcadeMinigame> ArcadeMinigame
		{
			get => GetPropertyValue<CEnum<ArcadeMinigame>>();
			set => SetPropertyValue<CEnum<ArcadeMinigame>>(value);
		}

		[Ordinal(106)] 
		[RED("DEBUG_enableArcadeMinigames")] 
		public CBool DEBUG_enableArcadeMinigames
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ArcadeMachineControllerPS()
		{
			DeviceName = "LocKey#1635";
			TweakDBRecord = 93060634862;
			TweakDBDescriptionRecord = 143953089827;
			GameVideosPaths = new();
			DEBUG_enableArcadeMinigames = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
