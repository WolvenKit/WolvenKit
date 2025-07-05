using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animUncompressedAllAnglesMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("frames")] 
		public CArray<Transform> Frames
		{
			get => GetPropertyValue<CArray<Transform>>();
			set => SetPropertyValue<CArray<Transform>>(value);
		}

		public animUncompressedAllAnglesMotionExtraction()
		{
			Duration = 1.000000F;
			Frames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
