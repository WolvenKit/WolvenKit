using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiQuadRacerPlayer : gameuiSideScrollerMiniGamePlayerController
	{
		[Ordinal(1)] 
		[RED("playerImage")] 
		public inkImageWidgetReference PlayerImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("leftTireSmoke")] 
		public inkImageWidgetReference LeftTireSmoke
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("rightTireSmoke")] 
		public inkImageWidgetReference RightTireSmoke
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rightFlame")] 
		public inkImageWidgetReference RightFlame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("leftFlame")] 
		public inkImageWidgetReference LeftFlame
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("leftTurnAtlasRegion")] 
		public CName LeftTurnAtlasRegion
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("rightTurnAtlasRegion")] 
		public CName RightTurnAtlasRegion
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("straightTurnAtlasRegion")] 
		public CName StraightTurnAtlasRegion
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiQuadRacerPlayer()
		{
			PlayerImage = new();
			LeftTireSmoke = new();
			RightTireSmoke = new();
			RightFlame = new();
			LeftFlame = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
