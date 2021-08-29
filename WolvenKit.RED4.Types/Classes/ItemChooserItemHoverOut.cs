using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemChooserItemHoverOut : redEvent
	{
		private CHandle<inkPointerEvent> _sourceEvent;

		[Ordinal(0)] 
		[RED("sourceEvent")] 
		public CHandle<inkPointerEvent> SourceEvent
		{
			get => GetProperty(ref _sourceEvent);
			set => SetProperty(ref _sourceEvent, value);
		}
	}
}
