using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioEventPrefetchStruct : RedBaseClass
	{
		private CName _eventName;
		private CEnum<questAudioEventPrefetchMode> _mode;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<questAudioEventPrefetchMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
