using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AuthorizePlayerInSecuritySystem : redEvent
	{
		[Ordinal(0)] 
		[RED("authorize")] 
		public CBool Authorize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("forceRemoveFromBlacklist")] 
		public CBool ForceRemoveFromBlacklist
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ESL")] 
		public CEnum<ESecurityAccessLevel> ESL
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		public AuthorizePlayerInSecuritySystem()
		{
			Authorize = true;
			ForceRemoveFromBlacklist = true;
			ESL = Enums.ESecurityAccessLevel.ESL_4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
