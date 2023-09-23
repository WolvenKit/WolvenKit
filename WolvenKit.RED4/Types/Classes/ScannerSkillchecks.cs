using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerSkillchecks : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("skillchecks")] 
		public CArray<UIInteractionSkillCheck> Skillchecks
		{
			get => GetPropertyValue<CArray<UIInteractionSkillCheck>>();
			set => SetPropertyValue<CArray<UIInteractionSkillCheck>>(value);
		}

		[Ordinal(1)] 
		[RED("authorizationRequired")] 
		public CBool AuthorizationRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isPlayerAuthorized")] 
		public CBool IsPlayerAuthorized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerSkillchecks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
