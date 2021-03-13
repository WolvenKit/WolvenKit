using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileVelocityParams : CVariable
	{
		[Ordinal(0)] [RED("xFactor")] public CFloat XFactor { get; set; }
		[Ordinal(1)] [RED("yFactor")] public CFloat YFactor { get; set; }
		[Ordinal(2)] [RED("zFactor")] public CFloat ZFactor { get; set; }

		public gameprojectileVelocityParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
