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
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("limitToSpecifiedSpeakersStations")] 
		public CBool LimitToSpecifiedSpeakersStations
		{
			get
			{
				if (_limitToSpecifiedSpeakersStations == null)
				{
					_limitToSpecifiedSpeakersStations = (CBool) CR2WTypeManager.Create("Bool", "limitToSpecifiedSpeakersStations", cr2w, this);
				}
				return _limitToSpecifiedSpeakersStations;
			}
			set
			{
				if (_limitToSpecifiedSpeakersStations == value)
				{
					return;
				}
				_limitToSpecifiedSpeakersStations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speakerType")] 
		public CEnum<audioRadioSpeakerType> SpeakerType
		{
			get
			{
				if (_speakerType == null)
				{
					_speakerType = (CEnum<audioRadioSpeakerType>) CR2WTypeManager.Create("audioRadioSpeakerType", "speakerType", cr2w, this);
				}
				return _speakerType;
			}
			set
			{
				if (_speakerType == value)
				{
					return;
				}
				_speakerType = value;
				PropertySet(this);
			}
		}

		public questRadio_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
