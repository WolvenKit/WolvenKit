using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnFindEntityInContextParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("contextualName")] 
		public CEnum<scnContextualActorName> ContextualName
		{
			get => GetPropertyValue<CEnum<scnContextualActorName>>();
			set => SetPropertyValue<CEnum<scnContextualActorName>>(value);
		}

		[Ordinal(1)] 
		[RED("voiceVagId")] 
		public scnVoicetagId VoiceVagId
		{
			get => GetPropertyValue<scnVoicetagId>();
			set => SetPropertyValue<scnVoicetagId>(value);
		}

		[Ordinal(2)] 
		[RED("contextActorName")] 
		public CName ContextActorName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("specRecordId")] 
		public TweakDBID SpecRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnFindEntityInContextParams()
		{
			VoiceVagId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
