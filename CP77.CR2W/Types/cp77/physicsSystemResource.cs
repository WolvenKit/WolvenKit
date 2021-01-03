using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsSystemResource : CResource
	{
		[Ordinal(0)]  [RED("bodies")] public CArray<CHandle<physicsSystemBody>> Bodies { get; set; }
		[Ordinal(1)]  [RED("joints")] public CArray<CHandle<physicsSystemJoint>> Joints { get; set; }

		public physicsSystemResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
