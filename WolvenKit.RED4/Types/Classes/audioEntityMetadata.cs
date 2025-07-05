using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEntityMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("fallbackDecorators")] 
		public CArray<CName> FallbackDecorators
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("defaultPositionName")] 
		public CName DefaultPositionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("defaultEmitterName")] 
		public CName DefaultEmitterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("isDefaultForEntityType")] 
		public CName IsDefaultForEntityType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("preferSoundComponentPosition")] 
		public CBool PreferSoundComponentPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("rigMetadata")] 
		public CName RigMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("emitterDescriptions")] 
		public CArray<audioEntityEmitterSettings> EmitterDescriptions
		{
			get => GetPropertyValue<CArray<audioEntityEmitterSettings>>();
			set => SetPropertyValue<CArray<audioEntityEmitterSettings>>(value);
		}

		[Ordinal(9)] 
		[RED("alwaysCreateDefaultEmitter")] 
		public CBool AlwaysCreateDefaultEmitter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioEntityMetadata()
		{
			FallbackDecorators = new();
			DefaultPositionName = "default";
			DefaultEmitterName = "default";
			Priority = 3;
			EmitterDescriptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
