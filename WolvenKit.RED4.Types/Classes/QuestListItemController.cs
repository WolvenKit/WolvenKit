using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListItemController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("trackedMarker")] 
		public inkWidgetReference TrackedMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("districtIcon")] 
		public inkImageWidgetReference DistrictIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("stateIcon")] 
		public inkImageWidgetReference StateIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("newIcon")] 
		public inkWidgetReference NewIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<QuestListItemData> Data
		{
			get => GetPropertyValue<CHandle<QuestListItemData>>();
			set => SetPropertyValue<CHandle<QuestListItemData>>(value);
		}

		[Ordinal(10)] 
		[RED("closestObjective")] 
		public CHandle<QuestListDistanceData> ClosestObjective
		{
			get => GetPropertyValue<CHandle<QuestListDistanceData>>();
			set => SetPropertyValue<CHandle<QuestListDistanceData>>(value);
		}

		[Ordinal(11)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public QuestListItemController()
		{
			Title = new();
			Level = new();
			TrackedMarker = new();
			DistrictIcon = new();
			StateIcon = new();
			Distance = new();
			Root = new();
			NewIcon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
