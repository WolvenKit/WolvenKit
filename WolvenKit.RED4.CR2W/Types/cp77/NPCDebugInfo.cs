using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDebugInfo : CVariable
	{
		private entEntityID _spawnerID;
		private CName _communityName;
		private CHandle<gamedataCharacter_Record> _characterRecord;

		[Ordinal(0)] 
		[RED("spawnerID")] 
		public entEntityID SpawnerID
		{
			get
			{
				if (_spawnerID == null)
				{
					_spawnerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "spawnerID", cr2w, this);
				}
				return _spawnerID;
			}
			set
			{
				if (_spawnerID == value)
				{
					return;
				}
				_spawnerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("communityName")] 
		public CName CommunityName
		{
			get
			{
				if (_communityName == null)
				{
					_communityName = (CName) CR2WTypeManager.Create("CName", "communityName", cr2w, this);
				}
				return _communityName;
			}
			set
			{
				if (_communityName == value)
				{
					return;
				}
				_communityName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("characterRecord")] 
		public CHandle<gamedataCharacter_Record> CharacterRecord
		{
			get
			{
				if (_characterRecord == null)
				{
					_characterRecord = (CHandle<gamedataCharacter_Record>) CR2WTypeManager.Create("handle:gamedataCharacter_Record", "characterRecord", cr2w, this);
				}
				return _characterRecord;
			}
			set
			{
				if (_characterRecord == value)
				{
					return;
				}
				_characterRecord = value;
				PropertySet(this);
			}
		}

		public NPCDebugInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
