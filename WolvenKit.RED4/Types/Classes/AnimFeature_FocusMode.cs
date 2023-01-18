using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_FocusMode : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_FocusMode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
