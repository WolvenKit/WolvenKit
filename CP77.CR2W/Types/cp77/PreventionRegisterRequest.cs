using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionRegisterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("requester")] public wCHandle<gameObject> Requester { get; set; }
		[Ordinal(1)] [RED("register")] public CBool Register { get; set; }

		public PreventionRegisterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
