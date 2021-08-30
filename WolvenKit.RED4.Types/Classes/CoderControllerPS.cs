using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		private CEnum<ESecurityAccessLevel> _providedAuthorizationLevel;

		[Ordinal(109)] 
		[RED("providedAuthorizationLevel")] 
		public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel
		{
			get => GetProperty(ref _providedAuthorizationLevel);
			set => SetProperty(ref _providedAuthorizationLevel, value);
		}

		public CoderControllerPS()
		{
			_providedAuthorizationLevel = new() { Value = Enums.ESecurityAccessLevel.ESL_4 };
		}
	}
}
