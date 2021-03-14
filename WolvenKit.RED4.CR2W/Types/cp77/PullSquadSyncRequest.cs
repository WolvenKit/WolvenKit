using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PullSquadSyncRequest : AIAIEvent
	{
		private CEnum<AISquadType> _squadType;

		[Ordinal(2)] 
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

		public PullSquadSyncRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
