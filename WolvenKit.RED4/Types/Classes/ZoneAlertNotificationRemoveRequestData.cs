using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoneAlertNotificationRemoveRequestData : IScriptable
	{
		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		public ZoneAlertNotificationRemoveRequestData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
