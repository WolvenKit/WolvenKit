using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleTimeDilatable : gameTimeDilatable
	{
		private CHandle<sampleTimeListener> _listener;

		[Ordinal(40)] 
		[RED("listener")] 
		public CHandle<sampleTimeListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}
	}
}
