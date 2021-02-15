using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SampleComponentWithCounterPS : gameComponentPS
	{
		[Ordinal(0)] [RED("counter")] public CInt32 Counter { get; set; }

		public SampleComponentWithCounterPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
