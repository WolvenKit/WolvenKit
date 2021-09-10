using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netFramesInputsHistory : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<netFrameInputs> Frames
		{
			get => GetPropertyValue<CArray<netFrameInputs>>();
			set => SetPropertyValue<CArray<netFrameInputs>>(value);
		}

		public netFramesInputsHistory()
		{
			Frames = new();
		}
	}
}
