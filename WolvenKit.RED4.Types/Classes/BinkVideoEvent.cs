using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BinkVideoEvent : redEvent
	{
		private redResourceReferenceScriptToken _path;
		private CFloat _startingTime;
		private CBool _shouldPlay;

		[Ordinal(0)] 
		[RED("path")] 
		public redResourceReferenceScriptToken Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("startingTime")] 
		public CFloat StartingTime
		{
			get => GetProperty(ref _startingTime);
			set => SetProperty(ref _startingTime, value);
		}

		[Ordinal(2)] 
		[RED("shouldPlay")] 
		public CBool ShouldPlay
		{
			get => GetProperty(ref _shouldPlay);
			set => SetProperty(ref _shouldPlay, value);
		}
	}
}
