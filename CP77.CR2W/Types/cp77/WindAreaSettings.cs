using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WindAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("direction")] public curveData<Vector4> Direction { get; set; }
		[Ordinal(1)]  [RED("strength")] public curveData<CFloat> Strength { get; set; }

		public WindAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
