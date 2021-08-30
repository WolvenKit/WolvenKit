using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleLock : ActionBool
	{
		private CBool _shouldOpen;

		[Ordinal(25)] 
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get => GetProperty(ref _shouldOpen);
			set => SetProperty(ref _shouldOpen, value);
		}

		public ToggleLock()
		{
			_shouldOpen = true;
		}
	}
}
