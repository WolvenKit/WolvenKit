using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_AnimatedDevice : animAnimFeature
	{
		private CBool _isOn;
		private CBool _isOff;

		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetProperty(ref _isOn);
			set => SetProperty(ref _isOn, value);
		}

		[Ordinal(1)] 
		[RED("isOff")] 
		public CBool IsOff
		{
			get => GetProperty(ref _isOff);
			set => SetProperty(ref _isOff, value);
		}
	}
}
