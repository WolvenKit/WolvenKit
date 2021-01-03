using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkBoxBlurEffect : inkIEffect
	{
		[Ordinal(0)]  [RED("blurDimension")] public CEnum<inkEBlurDimension> BlurDimension { get; set; }
		[Ordinal(1)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(2)]  [RED("samples")] public CUInt8 Samples { get; set; }

		public inkBoxBlurEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
