using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameLogicControllerAdvanced : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("playerLibraryName")] 
		public CName PlayerLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("playerColliderPositionOffset")] 
		public Vector2 PlayerColliderPositionOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("playerColliderSizeOffset")] 
		public Vector2 PlayerColliderSizeOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("gameplayRoot")] 
		public inkCompoundWidgetReference GameplayRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("layers")] 
		public CArray<inkWidgetReference> Layers
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("cheatCodes")] 
		public CArray<gameuiSideScrollerCheatCode> CheatCodes
		{
			get => GetPropertyValue<CArray<gameuiSideScrollerCheatCode>>();
			set => SetPropertyValue<CArray<gameuiSideScrollerCheatCode>>(value);
		}

		[Ordinal(8)] 
		[RED("acceptableCheatKeys")] 
		public CArray<CName> AcceptableCheatKeys
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameuiSideScrollerMiniGameLogicControllerAdvanced()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
