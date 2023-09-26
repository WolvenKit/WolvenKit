using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHudWidgetSpawnEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("contextVisibility")] 
		public CBitField<worlduiContextVisibility> ContextVisibility
		{
			get => GetPropertyValue<CBitField<worlduiContextVisibility>>();
			set => SetPropertyValue<CBitField<worlduiContextVisibility>>(value);
		}

		[Ordinal(3)] 
		[RED("gameContextVisibility")] 
		public CBitField<gameuiContext> GameContextVisibility
		{
			get => GetPropertyValue<CBitField<gameuiContext>>();
			set => SetPropertyValue<CBitField<gameuiContext>>(value);
		}

		[Ordinal(4)] 
		[RED("spawnMode")] 
		public CEnum<inkSpawnMode> SpawnMode
		{
			get => GetPropertyValue<CEnum<inkSpawnMode>>();
			set => SetPropertyValue<CEnum<inkSpawnMode>>(value);
		}

		[Ordinal(5)] 
		[RED("widgetResource")] 
		public CResourceReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(6)] 
		[RED("anchorPlace")] 
		public CEnum<inkEAnchor> AnchorPlace
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		[Ordinal(7)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(8)] 
		[RED("margins")] 
		public inkMargin Margins
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(9)] 
		[RED("attachToSlot")] 
		public CBool AttachToSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("slotParams")] 
		public inkWidgetSlotAttachmentParams SlotParams
		{
			get => GetPropertyValue<inkWidgetSlotAttachmentParams>();
			set => SetPropertyValue<inkWidgetSlotAttachmentParams>(value);
		}

		[Ordinal(11)] 
		[RED("useSeparateWindow")] 
		public CBool UseSeparateWindow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("ignoreHudSafezones")] 
		public CBool IgnoreHudSafezones
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("affectedByGlitchEffect")] 
		public CBool AffectedByGlitchEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("affectedByBlackwallEffect")] 
		public CBool AffectedByBlackwallEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("spawnBeforeSlots")] 
		public CBool SpawnBeforeSlots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkHudWidgetSpawnEntry()
		{
			Enabled = true;
			ContextVisibility = Enums.worlduiContextVisibility.SceneDefault | Enums.worlduiContextVisibility.SceneTier1 | Enums.worlduiContextVisibility.SceneTier2 | Enums.worlduiContextVisibility.SceneTier3 | Enums.worlduiContextVisibility.SceneTier4 | Enums.worlduiContextVisibility.SceneTier5;
			GameContextVisibility = Enums.gameuiContext.Default | Enums.gameuiContext.QuickHack | Enums.gameuiContext.Scanning | Enums.gameuiContext.BraindanceEditor | Enums.gameuiContext.BraindancePlayback | Enums.gameuiContext.VehicleMounted;
			AnchorPoint = new Vector2();
			Margins = new inkMargin();
			SlotParams = new inkWidgetSlotAttachmentParams { UseSlotLayout = true, LayoutOverride = new inkWidgetLayout { Padding = new inkMargin(), Margin = new inkMargin(), AnchorPoint = new Vector2(), SizeCoefficient = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
