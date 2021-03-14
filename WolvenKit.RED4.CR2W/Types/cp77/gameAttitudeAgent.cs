using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgent : gameComponent
	{
		private CName _baseAttitudeGroup;

		[Ordinal(4)] 
		[RED("baseAttitudeGroup")] 
		public CName BaseAttitudeGroup
		{
			get
			{
				if (_baseAttitudeGroup == null)
				{
					_baseAttitudeGroup = (CName) CR2WTypeManager.Create("CName", "baseAttitudeGroup", cr2w, this);
				}
				return _baseAttitudeGroup;
			}
			set
			{
				if (_baseAttitudeGroup == value)
				{
					return;
				}
				_baseAttitudeGroup = value;
				PropertySet(this);
			}
		}

		public gameAttitudeAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
