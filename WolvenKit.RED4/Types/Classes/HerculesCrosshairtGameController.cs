using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HerculesCrosshairtGameController : IronsightGameController
	{
		[Ordinal(63)] 
		[RED("appearanceFill")] 
		public CInt32 AppearanceFill
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(64)] 
		[RED("appearanceOutline")] 
		public CInt32 AppearanceOutline
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(65)] 
		[RED("appearanceShowThroughWalls")] 
		public CBool AppearanceShowThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("appearanceTransitionTime")] 
		public CFloat AppearanceTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(68)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(69)] 
		[RED("visionModeSystem")] 
		public CHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetPropertyValue<CHandle<gameVisionModeSystem>>();
			set => SetPropertyValue<CHandle<gameVisionModeSystem>>(value);
		}

		[Ordinal(70)] 
		[RED("targetedApperance")] 
		public gameVisionAppearance TargetedApperance
		{
			get => GetPropertyValue<gameVisionAppearance>();
			set => SetPropertyValue<gameVisionAppearance>(value);
		}

		[Ordinal(71)] 
		[RED("targets")] 
		public CArray<entEntityID> Targets
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public HerculesCrosshairtGameController()
		{
			Game = new ScriptGameInstance();
			TargetedApperance = new gameVisionAppearance();
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
