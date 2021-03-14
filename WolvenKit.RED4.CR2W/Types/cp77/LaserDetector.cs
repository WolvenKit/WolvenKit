using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LaserDetector : ProximityDetector
	{
		[Ordinal(92)] [RED("lasers", 2)] public CArrayFixedSize<CHandle<entMeshComponent>> Lasers { get; set; }

		public LaserDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
