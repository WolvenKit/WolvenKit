using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRenderScanEvent : redEvent
	{
		private CEnum<rendPostFx_ScanningState> _scanState;

		[Ordinal(0)] 
		[RED("scanState")] 
		public CEnum<rendPostFx_ScanningState> ScanState
		{
			get => GetProperty(ref _scanState);
			set => SetProperty(ref _scanState, value);
		}
	}
}
