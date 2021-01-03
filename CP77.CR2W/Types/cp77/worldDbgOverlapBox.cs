using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDbgOverlapBox : CVariable
	{
		[Ordinal(0)]  [RED("box")] public Box Box { get; set; }
		[Ordinal(1)]  [RED("isHit")] public CBool IsHit { get; set; }
		[Ordinal(2)]  [RED("level")] public CUInt32 Level { get; set; }
		[Ordinal(3)]  [RED("transform")] public Transform Transform { get; set; }

		public worldDbgOverlapBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
