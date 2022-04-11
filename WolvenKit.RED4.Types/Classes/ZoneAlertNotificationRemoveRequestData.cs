using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoneAlertNotificationRemoveRequestData : IScriptable
	{
		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}
	}
}
