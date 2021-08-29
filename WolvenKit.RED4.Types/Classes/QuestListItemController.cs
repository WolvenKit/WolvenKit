using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListItemController : inkWidgetLogicController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _level;
		private inkWidgetReference _trackedMarker;
		private inkImageWidgetReference _districtIcon;
		private inkImageWidgetReference _stateIcon;
		private inkTextWidgetReference _distance;
		private inkWidgetReference _root;
		private inkWidgetReference _newIcon;
		private CHandle<QuestListItemData> _data;
		private CHandle<QuestListDistanceData> _closestObjective;
		private CBool _hovered;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(3)] 
		[RED("trackedMarker")] 
		public inkWidgetReference TrackedMarker
		{
			get => GetProperty(ref _trackedMarker);
			set => SetProperty(ref _trackedMarker, value);
		}

		[Ordinal(4)] 
		[RED("districtIcon")] 
		public inkImageWidgetReference DistrictIcon
		{
			get => GetProperty(ref _districtIcon);
			set => SetProperty(ref _districtIcon, value);
		}

		[Ordinal(5)] 
		[RED("stateIcon")] 
		public inkImageWidgetReference StateIcon
		{
			get => GetProperty(ref _stateIcon);
			set => SetProperty(ref _stateIcon, value);
		}

		[Ordinal(6)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(7)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(8)] 
		[RED("newIcon")] 
		public inkWidgetReference NewIcon
		{
			get => GetProperty(ref _newIcon);
			set => SetProperty(ref _newIcon, value);
		}

		[Ordinal(9)] 
		[RED("data")] 
		public CHandle<QuestListItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(10)] 
		[RED("closestObjective")] 
		public CHandle<QuestListDistanceData> ClosestObjective
		{
			get => GetProperty(ref _closestObjective);
			set => SetProperty(ref _closestObjective, value);
		}

		[Ordinal(11)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(12)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}
	}
}
