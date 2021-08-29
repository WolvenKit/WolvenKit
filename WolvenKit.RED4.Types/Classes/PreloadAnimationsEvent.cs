using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreloadAnimationsEvent : redEvent
	{
		private CName _streamingContextName;
		private CBool _highPriority;

		[Ordinal(0)] 
		[RED("streamingContextName")] 
		public CName StreamingContextName
		{
			get => GetProperty(ref _streamingContextName);
			set => SetProperty(ref _streamingContextName, value);
		}

		[Ordinal(1)] 
		[RED("highPriority")] 
		public CBool HighPriority
		{
			get => GetProperty(ref _highPriority);
			set => SetProperty(ref _highPriority, value);
		}
	}
}
