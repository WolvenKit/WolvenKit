using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevokeAuthorization : redEvent
	{
		[Ordinal(0)] 
		[RED("user")] 
		public entEntityID User
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		public RevokeAuthorization()
		{
			User = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
