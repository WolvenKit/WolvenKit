using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetSlotAttachmentParams : CVariable
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

		public inkWidgetSlotAttachmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
