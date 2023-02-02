using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioConversationCharacterCondition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("characterRecordId")] 
		public CUInt64 CharacterRecordId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("actorContextName")] 
		public CName ActorContextName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("actorsInitialWorkspotNodeRefHash")] 
		public CUInt64 ActorsInitialWorkspotNodeRefHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public audioConversationCharacterCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
