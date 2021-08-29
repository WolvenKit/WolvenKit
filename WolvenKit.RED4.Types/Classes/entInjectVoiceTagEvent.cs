using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entInjectVoiceTagEvent : redEvent
	{
		private CName _voiceTagName;
		private CBool _forceInjection;

		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get => GetProperty(ref _voiceTagName);
			set => SetProperty(ref _voiceTagName, value);
		}

		[Ordinal(1)] 
		[RED("forceInjection")] 
		public CBool ForceInjection
		{
			get => GetProperty(ref _forceInjection);
			set => SetProperty(ref _forceInjection, value);
		}
	}
}
