using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionPoliceSecuritySystemRequest : gameScriptableSystemRequest
	{
		private gamePersistentID _securitySystemID;

		[Ordinal(0)] 
		[RED("securitySystemID")] 
		public gamePersistentID SecuritySystemID
		{
			get
			{
				if (_securitySystemID == null)
				{
					_securitySystemID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "securitySystemID", cr2w, this);
				}
				return _securitySystemID;
			}
			set
			{
				if (_securitySystemID == value)
				{
					return;
				}
				_securitySystemID = value;
				PropertySet(this);
			}
		}

		public PreventionPoliceSecuritySystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
