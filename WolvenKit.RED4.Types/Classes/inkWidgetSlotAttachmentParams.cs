using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetSlotAttachmentParams : RedBaseClass
	{
		private CName _slotID;
		private CBool _useSlotLayout;
		private inkWidgetLayout _layoutOverride;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("useSlotLayout")] 
		public CBool UseSlotLayout
		{
			get => GetProperty(ref _useSlotLayout);
			set => SetProperty(ref _useSlotLayout, value);
		}

		[Ordinal(2)] 
		[RED("layoutOverride")] 
		public inkWidgetLayout LayoutOverride
		{
			get => GetProperty(ref _layoutOverride);
			set => SetProperty(ref _layoutOverride, value);
		}

		public inkWidgetSlotAttachmentParams()
		{
			_useSlotLayout = true;
		}
	}
}
