using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponReloadSpeedData : animAnimFeature
	{
		[Ordinal(0)]  [RED("emptyReloadSpeed")] public CFloat EmptyReloadSpeed { get; set; }
		[Ordinal(1)]  [RED("reloadSpeed")] public CFloat ReloadSpeed { get; set; }

		public AnimFeature_WeaponReloadSpeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
