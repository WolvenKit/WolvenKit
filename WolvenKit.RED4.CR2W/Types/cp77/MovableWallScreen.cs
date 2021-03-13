using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableWallScreen : Door
	{
		[Ordinal(135)] [RED("animationLength")] public CFloat AnimationLength { get; set; }
		[Ordinal(136)] [RED("animFeature")] public CHandle<AnimFeature_SimpleDevice> AnimFeature { get; set; }

		public MovableWallScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
