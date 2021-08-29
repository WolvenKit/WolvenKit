using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SimpleDevice : animAnimFeatureMarkUnstable
	{
		private CBool _isOpen;
		private CBool _isOpenLeft;
		private CBool _isOpenRight;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("isOpenLeft")] 
		public CBool IsOpenLeft
		{
			get => GetProperty(ref _isOpenLeft);
			set => SetProperty(ref _isOpenLeft, value);
		}

		[Ordinal(2)] 
		[RED("isOpenRight")] 
		public CBool IsOpenRight
		{
			get => GetProperty(ref _isOpenRight);
			set => SetProperty(ref _isOpenRight, value);
		}
	}
}
