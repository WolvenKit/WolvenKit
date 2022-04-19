using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCAnimationBufferUncompressed : animIAnimationBuffer
	{
		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<CArray<QsTransform>> Transforms
		{
			get => GetPropertyValue<CArray<CArray<QsTransform>>>();
			set => SetPropertyValue<CArray<CArray<QsTransform>>>(value);
		}

		[Ordinal(1)] 
		[RED("tracks")] 
		public CArray<CArray<CFloat>> Tracks
		{
			get => GetPropertyValue<CArray<CArray<CFloat>>>();
			set => SetPropertyValue<CArray<CArray<CFloat>>>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animCAnimationBufferUncompressed()
		{
			Transforms = new();
			Tracks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
