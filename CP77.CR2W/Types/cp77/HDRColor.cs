using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HDRColor : CVariable
	{
		[Ordinal(0)]  [RED("Alpha")] public CFloat Alpha { get; set; }
		[Ordinal(1)]  [RED("Blue")] public CFloat Blue { get; set; }
		[Ordinal(2)]  [RED("Green")] public CFloat Green { get; set; }
		[Ordinal(3)]  [RED("Red")] public CFloat Red { get; set; }

		public HDRColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
