using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkBorderWidget : inkLeafWidget
	{
		[Ordinal(20)] [RED("thickness")] public CFloat Thickness { get; set; }

		public inkBorderWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
