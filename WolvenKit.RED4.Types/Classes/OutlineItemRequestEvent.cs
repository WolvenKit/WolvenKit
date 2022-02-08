using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OutlineItemRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get => GetPropertyValue<CHandle<OutlineRequest>>();
			set => SetPropertyValue<CHandle<OutlineRequest>>(value);
		}
	}
}
