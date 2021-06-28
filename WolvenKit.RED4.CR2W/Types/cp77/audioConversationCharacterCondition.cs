using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioConversationCharacterCondition : CVariable
	{
		private CName _voiceTag;
		private CUInt64 _characterRecordId;
		private CName _actorContextName;
		private CUInt64 _actorsInitialWorkspotNodeRefHash;

		[Ordinal(0)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get => GetProperty(ref _voiceTag);
			set => SetProperty(ref _voiceTag, value);
		}

		[Ordinal(1)] 
		[RED("characterRecordId")] 
		public CUInt64 CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}

		[Ordinal(2)] 
		[RED("actorContextName")] 
		public CName ActorContextName
		{
			get => GetProperty(ref _actorContextName);
			set => SetProperty(ref _actorContextName, value);
		}

		[Ordinal(3)] 
		[RED("actorsInitialWorkspotNodeRefHash")] 
		public CUInt64 ActorsInitialWorkspotNodeRefHash
		{
			get => GetProperty(ref _actorsInitialWorkspotNodeRefHash);
			set => SetProperty(ref _actorsInitialWorkspotNodeRefHash, value);
		}

		public audioConversationCharacterCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
