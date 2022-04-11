using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnAudioEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("ambientUniqueName")] 
		public CName AmbientUniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("fastForwardSupport")] 
		public CEnum<scnAudioFastForwardSupport> FastForwardSupport
		{
			get => GetPropertyValue<CEnum<scnAudioFastForwardSupport>>();
			set => SetPropertyValue<CEnum<scnAudioFastForwardSupport>>(value);
		}

		public scnAudioEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Performer = new() { Id = 4294967040 };
		}
	}
}
