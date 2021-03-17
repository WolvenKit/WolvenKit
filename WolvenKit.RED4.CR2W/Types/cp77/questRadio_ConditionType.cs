using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadio_ConditionType : questISystemConditionType
	{
		private CBool _inverted;
		private CBool _limitToSpecifiedSpeakersStations;
		private CEnum<audioRadioSpeakerType> _speakerType;

		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(1)] 
		[RED("limitToSpecifiedSpeakersStations")] 
		public CBool LimitToSpecifiedSpeakersStations
		{
			get => GetProperty(ref _limitToSpecifiedSpeakersStations);
			set => SetProperty(ref _limitToSpecifiedSpeakersStations, value);
		}

		[Ordinal(2)] 
		[RED("speakerType")] 
		public CEnum<audioRadioSpeakerType> SpeakerType
		{
			get => GetProperty(ref _speakerType);
			set => SetProperty(ref _speakerType, value);
		}

		public questRadio_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
