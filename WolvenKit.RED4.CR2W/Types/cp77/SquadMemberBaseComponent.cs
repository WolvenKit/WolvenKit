using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SquadMemberBaseComponent : gameSquadMemberComponent
	{
		private wCHandle<gamedataAISquadParams_Record> _baseSquadRecord;

		[Ordinal(4)] 
		[RED("baseSquadRecord")] 
		public wCHandle<gamedataAISquadParams_Record> BaseSquadRecord
		{
			get
			{
				if (_baseSquadRecord == null)
				{
					_baseSquadRecord = (wCHandle<gamedataAISquadParams_Record>) CR2WTypeManager.Create("whandle:gamedataAISquadParams_Record", "baseSquadRecord", cr2w, this);
				}
				return _baseSquadRecord;
			}
			set
			{
				if (_baseSquadRecord == value)
				{
					return;
				}
				_baseSquadRecord = value;
				PropertySet(this);
			}
		}

		public SquadMemberBaseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
