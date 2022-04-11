using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_FocusMode : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
