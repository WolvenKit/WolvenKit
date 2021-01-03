using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PreventionCombatStartedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("requester")] public wCHandle<gameObject> Requester { get; set; }
		[Ordinal(1)]  [RED("requesterPosition")] public Vector4 RequesterPosition { get; set; }

		public PreventionCombatStartedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
