using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

		public RevealPlayerSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
