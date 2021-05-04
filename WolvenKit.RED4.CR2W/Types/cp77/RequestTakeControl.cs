using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestTakeControl : gameScriptableSystemRequest
	{
		private entEntityID _requestSource;
		private CHandle<ToggleTakeOverControl> _originalEvent;

		[Ordinal(0)] 
		[RED("requestSource")] 
		public entEntityID RequestSource
		{
			get => GetProperty(ref _requestSource);
			set => SetProperty(ref _requestSource, value);
		}

		[Ordinal(1)] 
		[RED("originalEvent")] 
		public CHandle<ToggleTakeOverControl> OriginalEvent
		{
			get => GetProperty(ref _originalEvent);
			set => SetProperty(ref _originalEvent, value);
		}

		public RequestTakeControl(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
