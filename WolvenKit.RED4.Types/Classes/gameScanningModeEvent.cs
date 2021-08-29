using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningModeEvent : redEvent
	{
		private CEnum<gameScanningMode> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameScanningMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
