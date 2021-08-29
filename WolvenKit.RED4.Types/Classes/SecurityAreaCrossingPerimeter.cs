using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAreaCrossingPerimeter : SecurityAreaEvent
	{
		private CBool _entered;

		[Ordinal(27)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetProperty(ref _entered);
			set => SetProperty(ref _entered, value);
		}
	}
}
