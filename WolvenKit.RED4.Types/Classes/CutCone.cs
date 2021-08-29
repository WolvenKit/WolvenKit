using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CutCone : RedBaseClass
	{
		private Vector4 _positionAndRadius1;
		private Vector4 _normalAndRadius2;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("positionAndRadius1")] 
		public Vector4 PositionAndRadius1
		{
			get => GetProperty(ref _positionAndRadius1);
			set => SetProperty(ref _positionAndRadius1, value);
		}

		[Ordinal(1)] 
		[RED("normalAndRadius2")] 
		public Vector4 NormalAndRadius2
		{
			get => GetProperty(ref _normalAndRadius2);
			set => SetProperty(ref _normalAndRadius2, value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}
	}
}
