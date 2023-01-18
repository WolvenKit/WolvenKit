using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRadio_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("limitToSpecifiedSpeakersStations")] 
		public CBool LimitToSpecifiedSpeakersStations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("speakerType")] 
		public CEnum<audioRadioSpeakerType> SpeakerType
		{
			get => GetPropertyValue<CEnum<audioRadioSpeakerType>>();
			set => SetPropertyValue<CEnum<audioRadioSpeakerType>>(value);
		}

		public questRadio_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
