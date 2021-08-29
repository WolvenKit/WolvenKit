using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkVisualStateBlackBarsVisibilityChangedEvent : redEvent
	{
		private CBool _blackBarsVisible;

		[Ordinal(0)] 
		[RED("blackBarsVisible")] 
		public CBool BlackBarsVisible
		{
			get => GetProperty(ref _blackBarsVisible);
			set => SetProperty(ref _blackBarsVisible, value);
		}
	}
}
