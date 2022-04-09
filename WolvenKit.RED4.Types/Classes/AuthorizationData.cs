using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AuthorizationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isAuthorizationModuleOn")] 
		public CBool IsAuthorizationModuleOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("alwaysExposeActions")] 
		public CBool AlwaysExposeActions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("authorizationDataEntry")] 
		public SecurityAccessLevelEntryClient AuthorizationDataEntry
		{
			get => GetPropertyValue<SecurityAccessLevelEntryClient>();
			set => SetPropertyValue<SecurityAccessLevelEntryClient>(value);
		}

		public AuthorizationData()
		{
			IsAuthorizationModuleOn = true;
			AuthorizationDataEntry = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
