using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_DoorDevice : animAnimFeature
	{
		private CBool _isOpen;
		private CBool _isLocked;
		private CBool _isSealed;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(2)] 
		[RED("isSealed")] 
		public CBool IsSealed
		{
			get => GetProperty(ref _isSealed);
			set => SetProperty(ref _isSealed, value);
		}
	}
}
