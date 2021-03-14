using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgentPS : gameComponentPS
	{
		private CName _currentAttitudeGroup;

		[Ordinal(0)] 
		[RED("currentAttitudeGroup")] 
		public CName CurrentAttitudeGroup
		{
			get
			{
				if (_currentAttitudeGroup == null)
				{
					_currentAttitudeGroup = (CName) CR2WTypeManager.Create("CName", "currentAttitudeGroup", cr2w, this);
				}
				return _currentAttitudeGroup;
			}
			set
			{
				if (_currentAttitudeGroup == value)
				{
					return;
				}
				_currentAttitudeGroup = value;
				PropertySet(this);
			}
		}

		public gameAttitudeAgentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
