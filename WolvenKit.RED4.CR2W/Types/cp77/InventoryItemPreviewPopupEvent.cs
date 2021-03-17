using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewPopupEvent : redEvent
	{
		private CHandle<InventoryItemPreviewData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public InventoryItemPreviewPopupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
