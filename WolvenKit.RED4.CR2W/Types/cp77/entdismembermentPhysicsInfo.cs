using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentPhysicsInfo : CVariable
	{
		[Ordinal(0)] [RED("DensityScale")] public CFloat DensityScale { get; set; }

		public entdismembermentPhysicsInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
