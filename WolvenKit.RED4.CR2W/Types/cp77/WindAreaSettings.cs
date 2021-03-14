using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("strength")] public curveData<CFloat> Strength { get; set; }
		[Ordinal(3)] [RED("direction")] public curveData<Vector4> Direction { get; set; }

		public WindAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
