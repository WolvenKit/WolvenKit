using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimPlayVideoEvent : inkanimEvent
	{
		[Ordinal(0)]  [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }

		public inkanimPlayVideoEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
