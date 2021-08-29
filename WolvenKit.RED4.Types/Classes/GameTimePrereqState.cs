using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameTimePrereqState : gamePrereqState
	{
		private CUInt32 _listener;

		[Ordinal(0)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}
	}
}
