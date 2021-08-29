using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsVoicePlayedEvent : redEvent
	{
		private CName _eventName;
		private CEnum<audioVoGruntType> _gruntType;
		private CBool _isV;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(1)] 
		[RED("gruntType")] 
		public CEnum<audioVoGruntType> GruntType
		{
			get => GetProperty(ref _gruntType);
			set => SetProperty(ref _gruntType, value);
		}

		[Ordinal(2)] 
		[RED("isV")] 
		public CBool IsV
		{
			get => GetProperty(ref _isV);
			set => SetProperty(ref _isV, value);
		}
	}
}
