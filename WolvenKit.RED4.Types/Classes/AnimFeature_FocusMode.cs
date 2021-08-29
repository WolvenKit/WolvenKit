using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_FocusMode : animAnimFeature
	{
		private CBool _isFocusModeActive;

		[Ordinal(0)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetProperty(ref _isFocusModeActive);
			set => SetProperty(ref _isFocusModeActive, value);
		}
	}
}
