using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class senseSimpleSphere : senseIShape
	{
		[Ordinal(0)]  [RED("sphere")] public Sphere Sphere { get; set; }

		public senseSimpleSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
