using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSAnimationBufferBitwiseCompressedBoneTrack : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public animSAnimationBufferBitwiseCompressedData Position
		{
			get => GetPropertyValue<animSAnimationBufferBitwiseCompressedData>();
			set => SetPropertyValue<animSAnimationBufferBitwiseCompressedData>(value);
		}

		[Ordinal(1)] 
		[RED("orientation")] 
		public animSAnimationBufferBitwiseCompressedData Orientation
		{
			get => GetPropertyValue<animSAnimationBufferBitwiseCompressedData>();
			set => SetPropertyValue<animSAnimationBufferBitwiseCompressedData>(value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public animSAnimationBufferBitwiseCompressedData Scale
		{
			get => GetPropertyValue<animSAnimationBufferBitwiseCompressedData>();
			set => SetPropertyValue<animSAnimationBufferBitwiseCompressedData>(value);
		}

		public animSAnimationBufferBitwiseCompressedBoneTrack()
		{
			Position = new();
			Orientation = new();
			Scale = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
