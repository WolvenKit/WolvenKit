using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimTransparencyInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] [RED("startValue")] public CFloat StartValue { get; set; }
		[Ordinal(8)] [RED("endValue")] public CFloat EndValue { get; set; }

		public inkanimTransparencyInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
