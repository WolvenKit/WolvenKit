using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleDevice : animAnimFeatureMarkUnstable
	{
		[Ordinal(0)] [RED("isOpen")] public CBool IsOpen { get; set; }
		[Ordinal(1)] [RED("isOpenLeft")] public CBool IsOpenLeft { get; set; }
		[Ordinal(2)] [RED("isOpenRight")] public CBool IsOpenRight { get; set; }

		public AnimFeature_SimpleDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
