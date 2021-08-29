using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioFoliageMaterial : RedBaseClass
	{
		private CName _loopStart;
		private CName _loopEnd;

		[Ordinal(0)] 
		[RED("loopStart")] 
		public CName LoopStart
		{
			get => GetProperty(ref _loopStart);
			set => SetProperty(ref _loopStart, value);
		}

		[Ordinal(1)] 
		[RED("loopEnd")] 
		public CName LoopEnd
		{
			get => GetProperty(ref _loopEnd);
			set => SetProperty(ref _loopEnd, value);
		}
	}
}
