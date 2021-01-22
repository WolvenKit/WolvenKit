using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiScreenProjectionsData : IScriptable
	{
		[Ordinal(0)]  [RED("data")] public CArray<CHandle<inkScreenProjection>> Data { get; set; }

		public gameuiScreenProjectionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
