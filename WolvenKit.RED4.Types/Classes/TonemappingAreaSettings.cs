using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TonemappingAreaSettings : IAreaSettings
	{
		private CHandle<ITonemappingMode> _mode;
		private CHandle<ITonemappingMode> _hdrMode;

		[Ordinal(2)] 
		[RED("mode")] 
		public CHandle<ITonemappingMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(3)] 
		[RED("hdrMode")] 
		public CHandle<ITonemappingMode> HdrMode
		{
			get => GetProperty(ref _hdrMode);
			set => SetProperty(ref _hdrMode, value);
		}
	}
}
