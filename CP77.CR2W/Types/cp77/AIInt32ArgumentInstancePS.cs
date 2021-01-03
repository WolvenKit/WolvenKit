using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIInt32ArgumentInstancePS : AIArgumentInstancePS
	{
		[Ordinal(0)]  [RED("value")] public CInt32 Value { get; set; }

		public AIInt32ArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
