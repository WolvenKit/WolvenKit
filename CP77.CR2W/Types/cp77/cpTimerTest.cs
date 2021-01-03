using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpTimerTest : gameObject
	{
		[Ordinal(0)]  [RED("counter")] public CInt32 Counter { get; set; }

		public cpTimerTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
