using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerSkillchecks : ScannerChunk
	{
		private CArray<UIInteractionSkillCheck> _skillchecks;
		private CBool _authorizationRequired;
		private CBool _isPlayerAuthorized;

		[Ordinal(0)] 
		[RED("skillchecks")] 
		public CArray<UIInteractionSkillCheck> Skillchecks
		{
			get => GetProperty(ref _skillchecks);
			set => SetProperty(ref _skillchecks, value);
		}

		[Ordinal(1)] 
		[RED("authorizationRequired")] 
		public CBool AuthorizationRequired
		{
			get => GetProperty(ref _authorizationRequired);
			set => SetProperty(ref _authorizationRequired, value);
		}

		[Ordinal(2)] 
		[RED("isPlayerAuthorized")] 
		public CBool IsPlayerAuthorized
		{
			get => GetProperty(ref _isPlayerAuthorized);
			set => SetProperty(ref _isPlayerAuthorized, value);
		}
	}
}
