using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoneAlertNotificationRemoveRequestData : IScriptable
	{
		private CEnum<ESecurityAreaType> _areaType;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get
			{
				if (_areaType == null)
				{
					_areaType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "areaType", cr2w, this);
				}
				return _areaType;
			}
			set
			{
				if (_areaType == value)
				{
					return;
				}
				_areaType = value;
				PropertySet(this);
			}
		}

		public ZoneAlertNotificationRemoveRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
