using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficStaticCollisionSphere : CVariable
	{
		[Ordinal(0)] [RED("worldPos")] public Vector3 WorldPos { get; set; }

		public worldTrafficStaticCollisionSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
