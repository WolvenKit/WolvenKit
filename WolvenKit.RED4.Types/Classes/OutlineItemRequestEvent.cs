using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineItemRequestEvent : redEvent
	{
		private CHandle<OutlineRequest> _outlineRequest;

		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get => GetProperty(ref _outlineRequest);
			set => SetProperty(ref _outlineRequest, value);
		}
	}
}
