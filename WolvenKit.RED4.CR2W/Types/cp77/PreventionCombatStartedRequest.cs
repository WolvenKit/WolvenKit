using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionCombatStartedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("requesterPosition")] public Vector4 RequesterPosition { get; set; }
		[Ordinal(1)] [RED("requester")] public wCHandle<gameObject> Requester { get; set; }

		public PreventionCombatStartedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
