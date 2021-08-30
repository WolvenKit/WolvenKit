using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnToggleInterruption_InterruptionOperation : scnIInterruptionOperation
	{
		private CBool _enable;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public scnToggleInterruption_InterruptionOperation()
		{
			_enable = true;
		}
	}
}
