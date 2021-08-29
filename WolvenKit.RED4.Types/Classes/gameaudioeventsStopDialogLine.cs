using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsStopDialogLine : redEvent
	{
		private CRUID _stringId;
		private CFloat _fadeOut;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("fadeOut")] 
		public CFloat FadeOut
		{
			get => GetProperty(ref _fadeOut);
			set => SetProperty(ref _fadeOut, value);
		}
	}
}
