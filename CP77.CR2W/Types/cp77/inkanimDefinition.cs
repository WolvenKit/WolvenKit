using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimDefinition : IScriptable
	{
		[Ordinal(0)]  [RED("interpolators")] public CArray<CHandle<inkanimInterpolator>> Interpolators { get; set; }
		[Ordinal(1)]  [RED("events")] public CArray<CHandle<inkanimEvent>> Events { get; set; }

		public inkanimDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
