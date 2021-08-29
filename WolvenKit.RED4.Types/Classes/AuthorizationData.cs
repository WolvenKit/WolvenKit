using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AuthorizationData : RedBaseClass
	{
		private CBool _isAuthorizationModuleOn;
		private CBool _alwaysExposeActions;
		private SecurityAccessLevelEntryClient _authorizationDataEntry;

		[Ordinal(0)] 
		[RED("isAuthorizationModuleOn")] 
		public CBool IsAuthorizationModuleOn
		{
			get => GetProperty(ref _isAuthorizationModuleOn);
			set => SetProperty(ref _isAuthorizationModuleOn, value);
		}

		[Ordinal(1)] 
		[RED("alwaysExposeActions")] 
		public CBool AlwaysExposeActions
		{
			get => GetProperty(ref _alwaysExposeActions);
			set => SetProperty(ref _alwaysExposeActions, value);
		}

		[Ordinal(2)] 
		[RED("authorizationDataEntry")] 
		public SecurityAccessLevelEntryClient AuthorizationDataEntry
		{
			get => GetProperty(ref _authorizationDataEntry);
			set => SetProperty(ref _authorizationDataEntry, value);
		}
	}
}
