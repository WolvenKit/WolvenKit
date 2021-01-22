using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTagObjectRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("object")] public wCHandle<gameObject> Object { get; set; }

		public gameTagObjectRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
