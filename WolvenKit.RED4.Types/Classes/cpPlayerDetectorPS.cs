using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayerDetectorPS : gameObjectPS
	{
		private CInt32 _secondsCounter;

		[Ordinal(0)] 
		[RED("secondsCounter")] 
		public CInt32 SecondsCounter
		{
			get => GetProperty(ref _secondsCounter);
			set => SetProperty(ref _secondsCounter, value);
		}
	}
}
