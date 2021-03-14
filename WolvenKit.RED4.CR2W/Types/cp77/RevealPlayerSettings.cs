using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealPlayerSettings : CVariable
	{
		[Ordinal(0)] [RED("revealPlayer")] public CEnum<ERevealPlayerType> RevealPlayer { get; set; }
		[Ordinal(1)] [RED("revealPlayerOutsideSecurityPerimeter")] public CBool RevealPlayerOutsideSecurityPerimeter { get; set; }

		public RevealPlayerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
