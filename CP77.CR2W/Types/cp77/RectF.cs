using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RectF : CVariable
	{
		[Ordinal(0)]  [RED("Bottom")] public CFloat Bottom { get; set; }
		[Ordinal(1)]  [RED("Left")] public CFloat Left { get; set; }
		[Ordinal(2)]  [RED("Right")] public CFloat Right { get; set; }
		[Ordinal(3)]  [RED("Top")] public CFloat Top { get; set; }

		public RectF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
