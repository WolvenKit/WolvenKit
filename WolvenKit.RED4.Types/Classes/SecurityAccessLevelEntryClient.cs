using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
	{
		[Ordinal(2)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		public SecurityAccessLevelEntryClient()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
