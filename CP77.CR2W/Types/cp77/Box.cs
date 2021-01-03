using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Box : CVariable
	{
		[Ordinal(0)]  [RED("Max")] public Vector4 Max { get; set; }
		[Ordinal(1)]  [RED("Min")] public Vector4 Min { get; set; }

		public Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
