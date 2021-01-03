using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptCostModCircle : IScriptable
	{
		[Ordinal(0)]  [RED("cost")] public CFloat Cost { get; set; }
		[Ordinal(1)]  [RED("pos")] public Vector4 Pos { get; set; }
		[Ordinal(2)]  [RED("range")] public CFloat Range { get; set; }

		public worldNavigationScriptCostModCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
