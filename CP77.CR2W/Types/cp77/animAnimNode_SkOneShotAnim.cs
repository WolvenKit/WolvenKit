using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkOneShotAnim : animAnimNode_SkAnim
	{
		[Ordinal(0)]  [RED("Input")] public animPoseLink Input { get; set; }
		[Ordinal(1)]  [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(2)]  [RED("blendOut")] public CFloat BlendOut { get; set; }

		public animAnimNode_SkOneShotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
