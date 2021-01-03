using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponStats : animAnimFeature
	{
		[Ordinal(0)]  [RED("cycleTime")] public CFloat CycleTime { get; set; }
		[Ordinal(1)]  [RED("magazineCapacity")] public CInt32 MagazineCapacity { get; set; }

		public AnimFeature_WeaponStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
