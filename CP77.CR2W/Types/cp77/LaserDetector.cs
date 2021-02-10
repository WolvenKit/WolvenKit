using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LaserDetector : ProximityDetector
	{
		[Ordinal(83)]  [RED("lasers", 2)] public CArrayFixedSize<CHandle<entMeshComponent>> Lasers { get; set; }

		public LaserDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
