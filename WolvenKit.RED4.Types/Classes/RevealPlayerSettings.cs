using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealPlayerSettings : RedBaseClass
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
	}
}
