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
			get => GetProperty(ref _spawnerID);
			set => SetProperty(ref _spawnerID, value);
		}

		[Ordinal(1)] 
		[RED("communityName")] 
		public CName CommunityName
		{
			get => GetProperty(ref _communityName);
			set => SetProperty(ref _communityName, value);
		}

		[Ordinal(2)] 
		[RED("characterRecord")] 
		public CHandle<gamedataCharacter_Record> CharacterRecord
		{
			get => GetProperty(ref _characterRecord);
			set => SetProperty(ref _characterRecord, value);
		}

		public NPCDebugInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
