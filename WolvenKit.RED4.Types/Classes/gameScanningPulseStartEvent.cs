using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningPulseStartEvent : redEvent
	{
		private CInt32 _targetsAffected;

		[Ordinal(0)] 
		[RED("targetsAffected")] 
		public CInt32 TargetsAffected
		{
			get => GetProperty(ref _targetsAffected);
			set => SetProperty(ref _targetsAffected, value);
		}
	}
}
