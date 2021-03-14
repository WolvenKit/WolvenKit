using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RealTimeUpdateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("evt")] public CHandle<gameTickableEvent> Evt { get; set; }
		[Ordinal(1)] [RED("time")] public CFloat Time { get; set; }

		public RealTimeUpdateRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
