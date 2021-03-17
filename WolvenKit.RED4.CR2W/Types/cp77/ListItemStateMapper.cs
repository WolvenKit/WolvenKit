using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ListItemStateMapper : inkWidgetLogicController
	{
		private CBool _toggled;
		private CBool _selected;
		private CBool _new;
		private wCHandle<inkWidget> _widget;

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
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		public ListItemStateMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
