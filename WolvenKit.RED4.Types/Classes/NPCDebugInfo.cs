using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCDebugInfo : RedBaseClass
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
	}
}
