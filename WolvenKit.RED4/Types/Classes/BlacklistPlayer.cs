using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlacklistPlayer : redEvent
	{
		[Ordinal(0)] 
		[RED("blacklist")] 
		public CBool Blacklist
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public CEnum<BlacklistReason> Reason
		{
			get => GetPropertyValue<CEnum<BlacklistReason>>();
			set => SetPropertyValue<CEnum<BlacklistReason>>(value);
		}

		[Ordinal(2)] 
		[RED("forceRemoveAuthorization")] 
		public CBool ForceRemoveAuthorization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BlacklistPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
