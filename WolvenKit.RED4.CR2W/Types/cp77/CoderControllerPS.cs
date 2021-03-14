using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		private CEnum<ESecurityAccessLevel> _providedAuthorizationLevel;

		[Ordinal(108)] 
		[RED("providedAuthorizationLevel")] 
		public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel
		{
			get
			{
				if (_providedAuthorizationLevel == null)
				{
					_providedAuthorizationLevel = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "providedAuthorizationLevel", cr2w, this);
				}
				return _providedAuthorizationLevel;
			}
			set
			{
				if (_providedAuthorizationLevel == value)
				{
					return;
				}
				_providedAuthorizationLevel = value;
				PropertySet(this);
			}
		}

		public CoderControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
