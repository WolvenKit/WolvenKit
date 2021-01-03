using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkMargin : CVariable
	{
		[Ordinal(0)]  [RED("bottom")] public CFloat Bottom { get; set; }
		[Ordinal(1)]  [RED("left")] public CFloat Left { get; set; }
		[Ordinal(2)]  [RED("right")] public CFloat Right { get; set; }
		[Ordinal(3)]  [RED("top")] public CFloat Top { get; set; }

		public inkMargin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
