using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CompareBuilder : IScriptable
	{
		[Ordinal(0)]  [RED("FLOAT_EQUAL_EPSILON")] public CFloat FLOAT_EQUAL_EPSILON { get; set; }
		[Ordinal(1)]  [RED("value")] public CInt32 Value { get; set; }

		public CompareBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
