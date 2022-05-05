using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("providedAuthorizationLevel")] 
		public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		public CoderControllerPS()
		{
			ProvidedAuthorizationLevel = Enums.ESecurityAccessLevel.ESL_4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
