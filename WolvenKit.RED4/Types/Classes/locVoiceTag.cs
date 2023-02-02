using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class locVoiceTag : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("voicesetScenePath")] 
		public CString VoicesetScenePath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(3)] 
		[RED("isApuc")] 
		public CBool IsApuc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public locVoiceTag()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
