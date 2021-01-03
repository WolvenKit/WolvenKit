using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficStaticCollisionSphere : CVariable
	{
		[Ordinal(0)]  [RED("worldPos")] public Vector3 WorldPos { get; set; }

		public worldTrafficStaticCollisionSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
