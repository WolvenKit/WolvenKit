using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineItemRequestEvent : redEvent
	{
		private CHandle<OutlineRequest> _outlineRequest;

		[Ordinal(0)] 
		[RED("outlineRequest")] 
		public CHandle<OutlineRequest> OutlineRequest
		{
			get => GetProperty(ref _outlineRequest);
			set => SetProperty(ref _outlineRequest, value);
		}

		public OutlineItemRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
