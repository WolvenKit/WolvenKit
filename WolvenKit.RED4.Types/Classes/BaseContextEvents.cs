using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseContextEvents : InputContextTransitionEvents
	{
		private CInt32 _slicingFrame;

		[Ordinal(1)] 
		[RED("slicingFrame")] 
		public CInt32 SlicingFrame
		{
			get => GetProperty(ref _slicingFrame);
			set => SetProperty(ref _slicingFrame, value);
		}
	}
}
