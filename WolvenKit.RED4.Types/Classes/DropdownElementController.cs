using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropdownElementController : BaseButtonView
	{
		private inkTextWidgetReference _text;
		private inkImageWidgetReference _arrow;
		private inkWidgetReference _frame;
		private inkWidgetReference _contentContainer;
		private CHandle<DropdownItemData> _data;
		private CBool _active;

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(4)] 
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(5)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get => GetProperty(ref _contentContainer);
			set => SetProperty(ref _contentContainer, value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<DropdownItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}
	}
}
