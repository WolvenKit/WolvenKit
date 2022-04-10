using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPlaneUncompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] 
		[RED("frames")] 
		public CArray<Vector3> Frames
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animPlaneUncompressedMotionExtraction()
		{
			Frames = new();
			Duration = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
