using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Cylinder : RedBaseClass
	{
		private Vector4 _positionAndRadius;
		private Vector4 _normalAndHeight;

		[Ordinal(0)] 
		[RED("positionAndRadius")] 
		public Vector4 PositionAndRadius
		{
			get => GetProperty(ref _positionAndRadius);
			set => SetProperty(ref _positionAndRadius, value);
		}

		[Ordinal(1)] 
		[RED("normalAndHeight")] 
		public Vector4 NormalAndHeight
		{
			get => GetProperty(ref _normalAndHeight);
			set => SetProperty(ref _normalAndHeight, value);
		}
	}
}
