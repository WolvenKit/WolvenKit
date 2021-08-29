using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameTime : RedBaseClass
	{
		private CInt32 _seconds;

		[Ordinal(0)] 
		[RED("seconds")] 
		public CInt32 Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}
	}
}
