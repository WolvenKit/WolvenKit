using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealPlayerSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("revealPlayer")] 
		public CEnum<ERevealPlayerType> RevealPlayer
		{
			get => GetPropertyValue<CEnum<ERevealPlayerType>>();
			set => SetPropertyValue<CEnum<ERevealPlayerType>>(value);
		}

		[Ordinal(1)] 
		[RED("revealPlayerOutsideSecurityPerimeter")] 
		public CBool RevealPlayerOutsideSecurityPerimeter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
