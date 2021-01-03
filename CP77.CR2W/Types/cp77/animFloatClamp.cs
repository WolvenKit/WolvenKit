using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animFloatClamp : CVariable
	{
		[Ordinal(0)]  [RED("max")] public CFloat Max { get; set; }
		[Ordinal(1)]  [RED("min")] public CFloat Min { get; set; }
		[Ordinal(2)]  [RED("useMax")] public CBool UseMax { get; set; }
		[Ordinal(3)]  [RED("useMin")] public CBool UseMin { get; set; }

		public animFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
