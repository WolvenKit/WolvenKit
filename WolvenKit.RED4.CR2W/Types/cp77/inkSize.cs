using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSize : CVariable
	{
		[Ordinal(0)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(1)] [RED("height")] public CFloat Height { get; set; }

		public inkSize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
