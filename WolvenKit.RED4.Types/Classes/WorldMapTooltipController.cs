using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldMapTooltipController : WorldMapTooltipBaseController
	{
		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("descText")] 
		public inkTextWidgetReference DescText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("trackedQuestContainer")] 
		public inkWidgetReference TrackedQuestContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("requiredLevelCanvas")] 
		public inkWidgetReference RequiredLevelCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("requiredLevelText")] 
		public inkTextWidgetReference RequiredLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("requiredLevelValue")] 
		public inkTextWidgetReference RequiredLevelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("inputSetWaypointContainer")] 
		public inkCompoundWidgetReference InputSetWaypointContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("inputSetWaypointText")] 
		public inkTextWidgetReference InputSetWaypointText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("inputTrackQuestContainer")] 
		public inkCompoundWidgetReference InputTrackQuestContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("inputTrackQuestText")] 
		public inkTextWidgetReference InputTrackQuestText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("inputInteractContainer")] 
		public inkCompoundWidgetReference InputInteractContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("inputInteractText")] 
		public inkTextWidgetReference InputInteractText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("inputOpenJournalContainer")] 
		public inkCompoundWidgetReference InputOpenJournalContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("inputOpenJournalText")] 
		public inkTextWidgetReference InputOpenJournalText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("inputZoomToContainer")] 
		public inkCompoundWidgetReference InputZoomToContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("inputZoomToText")] 
		public inkTextWidgetReference InputZoomToText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("threatLevelCaption")] 
		public inkTextWidgetReference ThreatLevelCaption
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("threatLevelValue")] 
		public inkTextWidgetReference ThreatLevelValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("collectionCountContainer")] 
		public inkCompoundWidgetReference CollectionCountContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("collectionCountText")] 
		public inkTextWidgetReference CollectionCountText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public WorldMapTooltipController()
		{
			TitleText = new();
			DescText = new();
			TrackedQuestContainer = new();
			RequiredLevelCanvas = new();
			RequiredLevelText = new();
			RequiredLevelValue = new();
			InputSetWaypointContainer = new();
			InputSetWaypointText = new();
			InputTrackQuestContainer = new();
			InputTrackQuestText = new();
			InputInteractContainer = new();
			InputInteractText = new();
			InputOpenJournalContainer = new();
			InputOpenJournalText = new();
			InputZoomToContainer = new();
			InputZoomToText = new();
			ThreatLevelCaption = new();
			ThreatLevelValue = new();
			CollectionCountContainer = new();
			CollectionCountText = new();
		}
	}
}
