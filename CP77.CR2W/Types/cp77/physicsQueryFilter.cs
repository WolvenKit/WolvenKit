using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsQueryFilter : CVariable
	{
		[Ordinal(0)]  [RED("mask1")] public CUInt64 Mask1 { get; set; }
		[Ordinal(1)]  [RED("mask2")] public CUInt64 Mask2 { get; set; }

		public physicsQueryFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
