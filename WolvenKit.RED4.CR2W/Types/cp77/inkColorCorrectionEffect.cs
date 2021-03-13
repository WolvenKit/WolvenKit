using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkColorCorrectionEffect : inkIEffect
	{
		[Ordinal(2)] [RED("brightness")] public CFloat Brightness { get; set; }
		[Ordinal(3)] [RED("contrast")] public CFloat Contrast { get; set; }
		[Ordinal(4)] [RED("saturation")] public CFloat Saturation { get; set; }

		public inkColorCorrectionEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
