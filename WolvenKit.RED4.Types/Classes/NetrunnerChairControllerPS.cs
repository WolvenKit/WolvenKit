using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _killDelay;

		[Ordinal(104)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetProperty(ref _killDelay);
			set => SetProperty(ref _killDelay, value);
		}

		public NetrunnerChairControllerPS()
		{
			_killDelay = 1.000000F;
		}
	}
}
