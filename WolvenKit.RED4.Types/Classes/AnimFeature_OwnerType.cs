using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_OwnerType : animAnimFeature
	{
		private CInt32 _ownerEnum;

		[Ordinal(0)] 
		[RED("ownerEnum")] 
		public CInt32 OwnerEnum
		{
			get => GetProperty(ref _ownerEnum);
			set => SetProperty(ref _ownerEnum, value);
		}
	}
}
