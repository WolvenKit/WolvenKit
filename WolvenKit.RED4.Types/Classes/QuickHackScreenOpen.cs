using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackScreenOpen : redEvent
	{
		private CBool _setToOpen;

		[Ordinal(0)] 
		[RED("setToOpen")] 
		public CBool SetToOpen
		{
			get => GetProperty(ref _setToOpen);
			set => SetProperty(ref _setToOpen, value);
		}
	}
}
