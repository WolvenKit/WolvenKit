using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestTakeControl : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("requestSource")] public entEntityID RequestSource { get; set; }
		[Ordinal(1)] [RED("originalEvent")] public CHandle<ToggleTakeOverControl> OriginalEvent { get; set; }

		public RequestTakeControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
