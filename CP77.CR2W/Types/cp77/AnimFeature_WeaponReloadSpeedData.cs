using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReloadSpeedData : animAnimFeature
	{
		[Ordinal(0)] [RED("reloadSpeed")] public CFloat ReloadSpeed { get; set; }
		[Ordinal(1)] [RED("emptyReloadSpeed")] public CFloat EmptyReloadSpeed { get; set; }

		public AnimFeature_WeaponReloadSpeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
