using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CurveSetEntry : CVariable
	{
		[Ordinal(0)]  [RED("curve")] public curveData<CFloat> Curve { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }

		public CurveSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
