using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkBorderWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("thickness")] public CFloat Thickness { get; set; }

		public inkBorderWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
