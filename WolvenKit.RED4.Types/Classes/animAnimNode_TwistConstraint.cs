using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TwistConstraint : animAnimNode_OnePoseInput
	{
		private CEnum<animAxis> _frontAxis;
		private animTransformIndex _transformA;
		private animTransformIndex _transformB;
		private CArray<animTwistOutput> _outputs;
		private CBool _debug;

		[Ordinal(12)] 
		[RED("frontAxis")] 
		public CEnum<animAxis> FrontAxis
		{
			get => GetProperty(ref _frontAxis);
			set => SetProperty(ref _frontAxis, value);
		}

		[Ordinal(13)] 
		[RED("transformA")] 
		public animTransformIndex TransformA
		{
			get => GetProperty(ref _transformA);
			set => SetProperty(ref _transformA, value);
		}

		[Ordinal(14)] 
		[RED("transformB")] 
		public animTransformIndex TransformB
		{
			get => GetProperty(ref _transformB);
			set => SetProperty(ref _transformB, value);
		}

		[Ordinal(15)] 
		[RED("outputs")] 
		public CArray<animTwistOutput> Outputs
		{
			get => GetProperty(ref _outputs);
			set => SetProperty(ref _outputs, value);
		}

		[Ordinal(16)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetProperty(ref _debug);
			set => SetProperty(ref _debug, value);
		}
	}
}
