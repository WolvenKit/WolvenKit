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
			get
			{
				if (_canBeMerged == null)
				{
					_canBeMerged = (CBool) CR2WTypeManager.Create("Bool", "canBeMerged", cr2w, this);
				}
				return _canBeMerged;
			}
			set
			{
				if (_canBeMerged == value)
				{
					return;
				}
				_canBeMerged = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("securityZoneData")] 
		public CEnum<ESecurityAreaType> SecurityZoneData
		{
			get
			{
				if (_securityZoneData == null)
				{
					_securityZoneData = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "securityZoneData", cr2w, this);
				}
				return _securityZoneData;
			}
			set
			{
				if (_securityZoneData == value)
				{
					return;
				}
				_securityZoneData = value;
				PropertySet(this);
			}
		}

		public ZoneAlertNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
