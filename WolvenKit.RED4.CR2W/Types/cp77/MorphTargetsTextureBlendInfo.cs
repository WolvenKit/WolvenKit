using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetsTextureBlendInfo : CVariable
	{
		[Ordinal(0)] [RED("blend")] public CBool Blend { get; set; }
		[Ordinal(1)] [RED("diffSize")] public CEnum<MorphTargetsDiffTextureSize> DiffSize { get; set; }
		[Ordinal(2)] [RED("name")] public CName Name { get; set; }

		public MorphTargetsTextureBlendInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
