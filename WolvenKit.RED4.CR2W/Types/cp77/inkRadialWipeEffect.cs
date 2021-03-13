using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRadialWipeEffect : inkIEffect
	{
		[Ordinal(2)] [RED("startAngle")] public CFloat StartAngle { get; set; }
		[Ordinal(3)] [RED("transition")] public CFloat Transition { get; set; }

		public inkRadialWipeEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
