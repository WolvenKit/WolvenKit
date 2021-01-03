using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Quaternion : CVariable
	{
		[Ordinal(0)]  [RED("i")] public CFloat I { get; set; }
		[Ordinal(1)]  [RED("j")] public CFloat J { get; set; }
		[Ordinal(2)]  [RED("k")] public CFloat K { get; set; }
		[Ordinal(3)]  [RED("r")] public CFloat R { get; set; }

		public Quaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
