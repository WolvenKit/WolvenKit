using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSquadMemberDataEntry : CVariable
	{
		private CName _squadName;
		private CEnum<AISquadType> _squadType;

		[Ordinal(0)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get
			{
				if (_squadName == null)
				{
					_squadName = (CName) CR2WTypeManager.Create("CName", "squadName", cr2w, this);
				}
				return _squadName;
			}
			set
			{
				if (_squadName == value)
				{
					return;
				}
				_squadName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get
			{
				if (_squadType == null)
				{
					_squadType = (CEnum<AISquadType>) CR2WTypeManager.Create("AISquadType", "squadType", cr2w, this);
				}
				return _squadType;
			}
			set
			{
				if (_squadType == value)
				{
					return;
				}
				_squadType = value;
				PropertySet(this);
			}
		}

		public gameSquadMemberDataEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
