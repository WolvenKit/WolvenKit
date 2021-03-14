using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_MuzzleData : animAnimFeature
	{
		[Ordinal(0)] [RED("muzzleOffset")] public Vector4 MuzzleOffset { get; set; }

		public AnimFeature_MuzzleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
