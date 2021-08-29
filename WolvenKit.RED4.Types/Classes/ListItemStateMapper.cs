using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ListItemStateMapper : inkWidgetLogicController
	{
		private CBool _toggled;
		private CBool _selected;
		private CBool _new;
		private CWeakHandle<inkWidget> _widget;

		[Ordinal(1)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get => GetProperty(ref _toggled);
			set => SetProperty(ref _toggled, value);
		}

		[Ordinal(2)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}

		[Ordinal(3)] 
		[RED("new")] 
		public CBool New
		{
			get => GetProperty(ref _new);
			set => SetProperty(ref _new, value);
		}

		[Ordinal(4)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}
	}
}
