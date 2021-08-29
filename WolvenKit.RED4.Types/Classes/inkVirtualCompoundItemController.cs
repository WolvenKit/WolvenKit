using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVirtualCompoundItemController : inkButtonController
	{
		private inkVirtualCompoundItemControllerCallback _toggledOff;
		private inkVirtualCompoundItemControllerCallback _toggledOn;
		private inkVirtualCompoundItemSelectControllerCallback _selected_656;
		private inkVirtualCompoundItemControllerCallback _deselected;
		private inkVirtualCompoundItemControllerCallback _added;

		[Ordinal(10)] 
		[RED("ToggledOff")] 
		public inkVirtualCompoundItemControllerCallback ToggledOff
		{
			get => GetProperty(ref _toggledOff);
			set => SetProperty(ref _toggledOff, value);
		}

		[Ordinal(11)] 
		[RED("ToggledOn")] 
		public inkVirtualCompoundItemControllerCallback ToggledOn
		{
			get => GetProperty(ref _toggledOn);
			set => SetProperty(ref _toggledOn, value);
		}

		[Ordinal(12)] 
		[RED("Selected")] 
		public inkVirtualCompoundItemSelectControllerCallback Selected_656
		{
			get => GetProperty(ref _selected_656);
			set => SetProperty(ref _selected_656, value);
		}

		[Ordinal(13)] 
		[RED("Deselected")] 
		public inkVirtualCompoundItemControllerCallback Deselected
		{
			get => GetProperty(ref _deselected);
			set => SetProperty(ref _deselected, value);
		}

		[Ordinal(14)] 
		[RED("Added")] 
		public inkVirtualCompoundItemControllerCallback Added
		{
			get => GetProperty(ref _added);
			set => SetProperty(ref _added, value);
		}
	}
}
