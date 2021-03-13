using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ForkliftDevice : animAnimFeature
	{
		[Ordinal(0)] [RED("isUp")] public CBool IsUp { get; set; }
		[Ordinal(1)] [RED("isDown")] public CBool IsDown { get; set; }
		[Ordinal(2)] [RED("distract")] public CBool Distract { get; set; }

		public AnimFeature_ForkliftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
