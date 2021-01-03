using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionLatch : animAnimNode_QuaternionValue
	{
		[Ordinal(0)]  [RED("input")] public animQuaternionLink Input { get; set; }

		public animAnimNode_QuaternionLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
