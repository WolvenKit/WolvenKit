using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemForceAttitudeChange : ScriptableDeviceAction
	{
		private CName _newAttitude;

		[Ordinal(25)] 
		[RED("newAttitude")] 
		public CName NewAttitude
		{
			get
			{
				if (_newAttitude == null)
				{
					_newAttitude = (CName) CR2WTypeManager.Create("CName", "newAttitude", cr2w, this);
				}
				return _newAttitude;
			}
			set
			{
				if (_newAttitude == value)
				{
					return;
				}
				_newAttitude = value;
				PropertySet(this);
			}
		}

		public SecuritySystemForceAttitudeChange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
