using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionMinimapMappinComponent : IScriptable
	{
		[Ordinal(0)] 
		[RED("minimapStealthMappinController")] 
		public CWeakHandle<gameuiMinimapStealthMappinController> MinimapStealthMappinController
		{
			get => GetPropertyValue<CWeakHandle<gameuiMinimapStealthMappinController>>();
			set => SetPropertyValue<CWeakHandle<gameuiMinimapStealthMappinController>>(value);
		}

		[Ordinal(1)] 
		[RED("uiWantedBarBB")] 
		public CWeakHandle<gameIBlackboard> UiWantedBarBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(2)] 
		[RED("uiWantedBarBBDef")] 
		public CHandle<UI_WantedBarDef> UiWantedBarBBDef
		{
			get => GetPropertyValue<CHandle<UI_WantedBarDef>>();
			set => SetPropertyValue<CHandle<UI_WantedBarDef>>(value);
		}

		[Ordinal(3)] 
		[RED("currentWantedStateCallback")] 
		public CHandle<redCallbackObject> CurrentWantedStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("playerWanted")] 
		public CBool PlayerWanted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("playerEscapingPursuit")] 
		public CBool PlayerEscapingPursuit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("maxVisibilityDistance")] 
		public CFloat MaxVisibilityDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PreventionMinimapMappinComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
