using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_MuzzleData : animAnimFeature
	{
		private Vector4 _muzzleOffset;

		[Ordinal(0)] 
		[RED("muzzleOffset")] 
		public Vector4 MuzzleOffset
		{
			get => GetProperty(ref _muzzleOffset);
			set => SetProperty(ref _muzzleOffset, value);
		}
	}
}
