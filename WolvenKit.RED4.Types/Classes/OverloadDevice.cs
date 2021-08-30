using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OverloadDevice : ActionBool
	{
		private CFloat _killDelay;

		[Ordinal(25)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetProperty(ref _killDelay);
			set => SetProperty(ref _killDelay, value);
		}

		public OverloadDevice()
		{
			_killDelay = 1.000000F;
		}
	}
}
