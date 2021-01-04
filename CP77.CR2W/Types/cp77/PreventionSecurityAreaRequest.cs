using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionSecurityAreaRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("areaID")] public gamePersistentID AreaID { get; set; }
		[Ordinal(1)]  [RED("playerIsIn")] public CBool PlayerIsIn { get; set; }

		public PreventionSecurityAreaRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
