using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSideScrollerMiniGameLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("startHealth")] 
		public CUInt32 StartHealth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("playerLibraryName")] 
		public CName PlayerLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("playerColliderPositionOffset")] 
		public Vector2 PlayerColliderPositionOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("playerColliderSizeOffset")] 
		public Vector2 PlayerColliderSizeOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(6)] 
		[RED("gameplayRoot")] 
		public inkCompoundWidgetReference GameplayRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("spawnedListLibraryNames")] 
		public CArray<CName> SpawnedListLibraryNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(9)] 
		[RED("isGameRunning")] 
		public CBool IsGameRunning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiSideScrollerMiniGameLogicController()
		{
			StartHealth = 3;
			PlayerColliderPositionOffset = new();
			PlayerColliderSizeOffset = new();
			GameplayRoot = new();
			SpawnedListLibraryNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
