using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RequestTakeControl : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("originalEvent")] public CHandle<ToggleTakeOverControl> OriginalEvent { get; set; }
		[Ordinal(1)]  [RED("requestSource")] public entEntityID RequestSource { get; set; }

		public RequestTakeControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
