using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkUITransform : RedBaseClass
	{
		private Vector2 _translation;
		private Vector2 _scale;
		private Vector2 _shear;
		private CFloat _rotation;

		[Ordinal(0)] 
		[RED("translation")] 
		public Vector2 Translation
		{
			get => GetProperty(ref _translation);
			set => SetProperty(ref _translation, value);
		}

		[Ordinal(1)] 
		[RED("scale")] 
		public Vector2 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(2)] 
		[RED("shear")] 
		public Vector2 Shear
		{
			get => GetProperty(ref _shear);
			set => SetProperty(ref _shear, value);
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}
	}
}
