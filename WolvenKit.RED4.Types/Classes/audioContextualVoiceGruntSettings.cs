using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioContextualVoiceGruntSettings : RedBaseClass
	{
		private audioContextualVoiceGrunt _painShort;
		private audioContextualVoiceGrunt _effort;

		[Ordinal(0)] 
		[RED("painShort")] 
		public audioContextualVoiceGrunt PainShort
		{
			get => GetProperty(ref _painShort);
			set => SetProperty(ref _painShort, value);
		}

		[Ordinal(1)] 
		[RED("effort")] 
		public audioContextualVoiceGrunt Effort
		{
			get => GetProperty(ref _effort);
			set => SetProperty(ref _effort, value);
		}
	}
}
