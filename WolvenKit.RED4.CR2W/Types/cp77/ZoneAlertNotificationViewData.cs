using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotificationViewData : gameuiGenericNotificationViewData
	{
		private CBool _canBeMerged;
		private CEnum<ESecurityAreaType> _securityZoneData;

		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetProperty(ref _canBeMerged);
			set => SetProperty(ref _canBeMerged, value);
		}

		[Ordinal(6)] 
		[RED("securityZoneData")] 
		public CEnum<ESecurityAreaType> SecurityZoneData
		{
			get => GetProperty(ref _securityZoneData);
			set => SetProperty(ref _securityZoneData, value);
		}

		public ZoneAlertNotificationViewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
