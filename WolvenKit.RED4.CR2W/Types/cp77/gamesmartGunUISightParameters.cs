using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUISightParameters : CVariable
	{
		[Ordinal(0)] [RED("center")] public Vector2 Center { get; set; }
		[Ordinal(1)] [RED("targetableRegionSize")] public Vector2 TargetableRegionSize { get; set; }
		[Ordinal(2)] [RED("reticleSize")] public Vector2 ReticleSize { get; set; }

		public gamesmartGunUISightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
