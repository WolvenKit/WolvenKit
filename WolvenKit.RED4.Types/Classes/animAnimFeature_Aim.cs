using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_Aim : animAnimFeature_BasicAim
	{
		private Vector4 _aimPoint;

		[Ordinal(2)] 
		[RED("aimPoint")] 
		public Vector4 AimPoint
		{
			get => GetProperty(ref _aimPoint);
			set => SetProperty(ref _aimPoint, value);
		}
	}
}
