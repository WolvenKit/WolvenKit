using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animUncompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<Vector4> Frames
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animUncompressedMotionExtraction()
		{
			Frames = new();
			Duration = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
