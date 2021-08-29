using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netFramesInputsHistory : RedBaseClass
	{
		private CArray<netFrameInputs> _frames;

		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<netFrameInputs> Frames
		{
			get => GetProperty(ref _frames);
			set => SetProperty(ref _frames, value);
		}
	}
}
