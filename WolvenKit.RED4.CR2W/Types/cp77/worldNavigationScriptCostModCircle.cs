using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptCostModCircle : IScriptable
	{
		[Ordinal(0)] [RED("pos")] public Vector4 Pos { get; set; }
		[Ordinal(1)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(2)] [RED("cost")] public CFloat Cost { get; set; }

		public worldNavigationScriptCostModCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
