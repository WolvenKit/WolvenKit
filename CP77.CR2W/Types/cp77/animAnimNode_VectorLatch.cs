using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorLatch : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("input")] public animVectorLink Input { get; set; }

		public animAnimNode_VectorLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
