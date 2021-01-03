using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkColorCorrectionEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("brightness")] public CFloat Brightness { get; set; }
		[Ordinal(1)]  [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(2)]  [RED("saturation")] public CFloat Saturation { get; set; }

		public inkColorCorrectionEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
