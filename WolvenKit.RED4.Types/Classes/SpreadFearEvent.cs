using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpreadFearEvent : redEvent
	{
		private CBool _player;
		private CInt32 _phase;

		[Ordinal(0)] 
		[RED("player")] 
		public CBool Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CInt32 Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}
	}
}
