using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NCPDJobDoneEvent : redEvent
	{
		private CInt32 _levelXPAwarded;
		private CInt32 _streetCredXPAwarded;

		[Ordinal(0)] 
		[RED("levelXPAwarded")] 
		public CInt32 LevelXPAwarded
		{
			get => GetProperty(ref _levelXPAwarded);
			set => SetProperty(ref _levelXPAwarded, value);
		}

		[Ordinal(1)] 
		[RED("streetCredXPAwarded")] 
		public CInt32 StreetCredXPAwarded
		{
			get => GetProperty(ref _streetCredXPAwarded);
			set => SetProperty(ref _streetCredXPAwarded, value);
		}
	}
}
