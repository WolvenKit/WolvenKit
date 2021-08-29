using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScanInstance : ModuleInstance
	{
		private CBool _isScanningCluesBlocked;

		[Ordinal(6)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetProperty(ref _isScanningCluesBlocked);
			set => SetProperty(ref _isScanningCluesBlocked, value);
		}
	}
}
