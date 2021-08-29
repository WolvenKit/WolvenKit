using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animCollisionRoundedShape : RedBaseClass
	{
		private animTransformIndex _bone;
		private QsTransform _transformLS;
		private CFloat _roundedCornerRadius;
		private CFloat _xBoxExtent;
		private CFloat _yBoxExtent;
		private CFloat _zBoxExtent;

		[Ordinal(0)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(1)] 
		[RED("transformLS")] 
		public QsTransform TransformLS
		{
			get => GetProperty(ref _transformLS);
			set => SetProperty(ref _transformLS, value);
		}

		[Ordinal(2)] 
		[RED("roundedCornerRadius")] 
		public CFloat RoundedCornerRadius
		{
			get => GetProperty(ref _roundedCornerRadius);
			set => SetProperty(ref _roundedCornerRadius, value);
		}

		[Ordinal(3)] 
		[RED("xBoxExtent")] 
		public CFloat XBoxExtent
		{
			get => GetProperty(ref _xBoxExtent);
			set => SetProperty(ref _xBoxExtent, value);
		}

		[Ordinal(4)] 
		[RED("yBoxExtent")] 
		public CFloat YBoxExtent
		{
			get => GetProperty(ref _yBoxExtent);
			set => SetProperty(ref _yBoxExtent, value);
		}

		[Ordinal(5)] 
		[RED("zBoxExtent")] 
		public CFloat ZBoxExtent
		{
			get => GetProperty(ref _zBoxExtent);
			set => SetProperty(ref _zBoxExtent, value);
		}
	}
}
