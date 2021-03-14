using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_PlaySound : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] [RED("soundName")] public CName SoundName { get; set; }
		[Ordinal(1)] [RED("unique")] public CBool Unique { get; set; }

		public gameTransformAnimation_PlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
