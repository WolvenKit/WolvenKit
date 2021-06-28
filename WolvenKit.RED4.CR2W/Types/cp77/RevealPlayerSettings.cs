using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealPlayerSettings : CVariable
	{
		private CEnum<ERevealPlayerType> _revealPlayer;
		private CBool _revealPlayerOutsideSecurityPerimeter;

		[Ordinal(0)] 
		[RED("revealPlayer")] 
		public CEnum<ERevealPlayerType> RevealPlayer
		{
			get => GetProperty(ref _revealPlayer);
			set => SetProperty(ref _revealPlayer, value);
		}

		[Ordinal(1)] 
		[RED("revealPlayerOutsideSecurityPerimeter")] 
		public CBool RevealPlayerOutsideSecurityPerimeter
		{
			get => GetProperty(ref _revealPlayerOutsideSecurityPerimeter);
			set => SetProperty(ref _revealPlayerOutsideSecurityPerimeter, value);
		}

		public RevealPlayerSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
