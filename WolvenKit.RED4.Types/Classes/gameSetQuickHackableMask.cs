using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetQuickHackableMask : redEvent
	{
		private CBool _isQuickHackable;

		[Ordinal(0)] 
		[RED("isQuickHackable")] 
		public CBool IsQuickHackable
		{
			get => GetProperty(ref _isQuickHackable);
			set => SetProperty(ref _isQuickHackable, value);
		}
	}
}
