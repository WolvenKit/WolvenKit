using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayBinkEvent : redEvent
	{
		private SBinkperationData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public SBinkperationData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
