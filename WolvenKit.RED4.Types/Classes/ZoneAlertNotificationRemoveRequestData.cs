using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoneAlertNotificationRemoveRequestData : IScriptable
	{
		private CEnum<ESecurityAreaType> _areaType;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}
	}
}
