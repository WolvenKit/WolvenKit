using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkListItemController : inkButtonController
	{
		private inkListItemControllerCallback _toggledOff;
		private inkListItemControllerCallback _toggledOn;
		private inkListItemControllerCallback _selected_656;
		private inkListItemControllerCallback _deselected;
		private inkListItemControllerCallback _addedToList;
		private inkTextWidgetReference _labelPathRef;

		[Ordinal(10)] 
		[RED("ToggledOff")] 
		public inkListItemControllerCallback ToggledOff
		{
			get => GetProperty(ref _toggledOff);
			set => SetProperty(ref _toggledOff, value);
		}

		[Ordinal(11)] 
		[RED("ToggledOn")] 
		public inkListItemControllerCallback ToggledOn
		{
			get => GetProperty(ref _toggledOn);
			set => SetProperty(ref _toggledOn, value);
		}

		[Ordinal(12)] 
		[RED("Selected")] 
		public inkListItemControllerCallback Selected_656
		{
			get => GetProperty(ref _selected_656);
			set => SetProperty(ref _selected_656, value);
		}

		[Ordinal(13)] 
		[RED("Deselected")] 
		public inkListItemControllerCallback Deselected
		{
			get => GetProperty(ref _deselected);
			set => SetProperty(ref _deselected, value);
		}

		[Ordinal(14)] 
		[RED("AddedToList")] 
		public inkListItemControllerCallback AddedToList
		{
			get => GetProperty(ref _addedToList);
			set => SetProperty(ref _addedToList, value);
		}

		[Ordinal(15)] 
		[RED("labelPathRef")] 
		public inkTextWidgetReference LabelPathRef
		{
			get => GetProperty(ref _labelPathRef);
			set => SetProperty(ref _labelPathRef, value);
		}
	}
}
