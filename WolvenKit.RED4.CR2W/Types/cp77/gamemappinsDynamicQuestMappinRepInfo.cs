using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsDynamicQuestMappinRepInfo : CVariable
	{
		private CUInt32 _journalPathHash;
		private wCHandle<entEntity> _entity;

		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get
			{
				if (_journalPathHash == null)
				{
					_journalPathHash = (CUInt32) CR2WTypeManager.Create("Uint32", "journalPathHash", cr2w, this);
				}
				return _journalPathHash;
			}
			set
			{
				if (_journalPathHash == value)
				{
					return;
				}
				_journalPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		public gamemappinsDynamicQuestMappinRepInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
