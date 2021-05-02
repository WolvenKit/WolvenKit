using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipController : WorldMapTooltipBaseController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _descText;
		private inkWidgetReference _trackedQuestContainer;
		private inkWidgetReference _requiredLevelCanvas;
		private inkTextWidgetReference _requiredLevelText;
		private inkTextWidgetReference _requiredLevelValue;
		private inkCompoundWidgetReference _inputSetWaypointContainer;
		private inkTextWidgetReference _inputSetWaypointText;
		private inkCompoundWidgetReference _inputTrackQuestContainer;
		private inkTextWidgetReference _inputTrackQuestText;
		private inkCompoundWidgetReference _inputInteractContainer;
		private inkTextWidgetReference _inputInteractText;
		private inkCompoundWidgetReference _inputOpenJournalContainer;
		private inkTextWidgetReference _inputOpenJournalText;
		private inkCompoundWidgetReference _inputZoomToContainer;
		private inkTextWidgetReference _inputZoomToText;
		private inkTextWidgetReference _threatLevelCaption;
		private inkTextWidgetReference _threatLevelValue;
		private inkCompoundWidgetReference _collectionCountContainer;
		private inkTextWidgetReference _collectionCountText;

		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(6)] 
		[RED("descText")] 
		public inkTextWidgetReference DescText
		{
			get => GetProperty(ref _descText);
			set => SetProperty(ref _descText, value);
		}

		[Ordinal(7)] 
		[RED("trackedQuestContainer")] 
		public inkWidgetReference TrackedQuestContainer
		{
			get => GetProperty(ref _trackedQuestContainer);
			set => SetProperty(ref _trackedQuestContainer, value);
		}

		[Ordinal(8)] 
		[RED("requiredLevelCanvas")] 
		public inkWidgetReference RequiredLevelCanvas
		{
			get => GetProperty(ref _requiredLevelCanvas);
			set => SetProperty(ref _requiredLevelCanvas, value);
		}

		[Ordinal(9)] 
		[RED("requiredLevelText")] 
		public inkTextWidgetReference RequiredLevelText
		{
			get => GetProperty(ref _requiredLevelText);
			set => SetProperty(ref _requiredLevelText, value);
		}

		[Ordinal(10)] 
		[RED("requiredLevelValue")] 
		public inkTextWidgetReference RequiredLevelValue
		{
			get => GetProperty(ref _requiredLevelValue);
			set => SetProperty(ref _requiredLevelValue, value);
		}

		[Ordinal(11)] 
		[RED("inputSetWaypointContainer")] 
		public inkCompoundWidgetReference InputSetWaypointContainer
		{
			get => GetProperty(ref _inputSetWaypointContainer);
			set => SetProperty(ref _inputSetWaypointContainer, value);
		}

		[Ordinal(12)] 
		[RED("inputSetWaypointText")] 
		public inkTextWidgetReference InputSetWaypointText
		{
			get => GetProperty(ref _inputSetWaypointText);
			set => SetProperty(ref _inputSetWaypointText, value);
		}

		[Ordinal(13)] 
		[RED("inputTrackQuestContainer")] 
		public inkCompoundWidgetReference InputTrackQuestContainer
		{
			get => GetProperty(ref _inputTrackQuestContainer);
			set => SetProperty(ref _inputTrackQuestContainer, value);
		}

		[Ordinal(14)] 
		[RED("inputTrackQuestText")] 
		public inkTextWidgetReference InputTrackQuestText
		{
			get => GetProperty(ref _inputTrackQuestText);
			set => SetProperty(ref _inputTrackQuestText, value);
		}

		[Ordinal(15)] 
		[RED("inputInteractContainer")] 
		public inkCompoundWidgetReference InputInteractContainer
		{
			get => GetProperty(ref _inputInteractContainer);
			set => SetProperty(ref _inputInteractContainer, value);
		}

		[Ordinal(16)] 
		[RED("inputInteractText")] 
		public inkTextWidgetReference InputInteractText
		{
			get => GetProperty(ref _inputInteractText);
			set => SetProperty(ref _inputInteractText, value);
		}

		[Ordinal(17)] 
		[RED("inputOpenJournalContainer")] 
		public inkCompoundWidgetReference InputOpenJournalContainer
		{
			get => GetProperty(ref _inputOpenJournalContainer);
			set => SetProperty(ref _inputOpenJournalContainer, value);
		}

		[Ordinal(18)] 
		[RED("inputOpenJournalText")] 
		public inkTextWidgetReference InputOpenJournalText
		{
			get => GetProperty(ref _inputOpenJournalText);
			set => SetProperty(ref _inputOpenJournalText, value);
		}

		[Ordinal(19)] 
		[RED("inputZoomToContainer")] 
		public inkCompoundWidgetReference InputZoomToContainer
		{
			get => GetProperty(ref _inputZoomToContainer);
			set => SetProperty(ref _inputZoomToContainer, value);
		}

		[Ordinal(20)] 
		[RED("inputZoomToText")] 
		public inkTextWidgetReference InputZoomToText
		{
			get => GetProperty(ref _inputZoomToText);
			set => SetProperty(ref _inputZoomToText, value);
		}

		[Ordinal(21)] 
		[RED("threatLevelCaption")] 
		public inkTextWidgetReference ThreatLevelCaption
		{
			get => GetProperty(ref _threatLevelCaption);
			set => SetProperty(ref _threatLevelCaption, value);
		}

		[Ordinal(22)] 
		[RED("threatLevelValue")] 
		public inkTextWidgetReference ThreatLevelValue
		{
			get => GetProperty(ref _threatLevelValue);
			set => SetProperty(ref _threatLevelValue, value);
		}

		[Ordinal(23)] 
		[RED("collectionCountContainer")] 
		public inkCompoundWidgetReference CollectionCountContainer
		{
			get => GetProperty(ref _collectionCountContainer);
			set => SetProperty(ref _collectionCountContainer, value);
		}

		[Ordinal(24)] 
		[RED("collectionCountText")] 
		public inkTextWidgetReference CollectionCountText
		{
			get => GetProperty(ref _collectionCountText);
			set => SetProperty(ref _collectionCountText, value);
		}

		public WorldMapTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
