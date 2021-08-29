using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemForwardDecal : effectTrackItem
	{
		private CResourceReference<CMesh> _mesh;
		private CName _appearance;
		private CHandle<IEvaluatorVector> _scale;
		private CFloat _additionalRotation;
		private CFloat _sizeThreshold;
		private CBool _randomRotation;
		private CBool _randomAppearance;
		private CBool _isAttached;
		private CUInt32 _subUVx;
		private CUInt32 _subUVy;
		private CUInt32 _frame;
		private CFloat _fadeOutTime;
		private CFloat _fadeInTime;

		[Ordinal(3)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(4)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetProperty(ref _appearance);
			set => SetProperty(ref _appearance, value);
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CHandle<IEvaluatorVector> Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(6)] 
		[RED("additionalRotation")] 
		public CFloat AdditionalRotation
		{
			get => GetProperty(ref _additionalRotation);
			set => SetProperty(ref _additionalRotation, value);
		}

		[Ordinal(7)] 
		[RED("sizeThreshold")] 
		public CFloat SizeThreshold
		{
			get => GetProperty(ref _sizeThreshold);
			set => SetProperty(ref _sizeThreshold, value);
		}

		[Ordinal(8)] 
		[RED("randomRotation")] 
		public CBool RandomRotation
		{
			get => GetProperty(ref _randomRotation);
			set => SetProperty(ref _randomRotation, value);
		}

		[Ordinal(9)] 
		[RED("randomAppearance")] 
		public CBool RandomAppearance
		{
			get => GetProperty(ref _randomAppearance);
			set => SetProperty(ref _randomAppearance, value);
		}

		[Ordinal(10)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get => GetProperty(ref _isAttached);
			set => SetProperty(ref _isAttached, value);
		}

		[Ordinal(11)] 
		[RED("subUVx")] 
		public CUInt32 SubUVx
		{
			get => GetProperty(ref _subUVx);
			set => SetProperty(ref _subUVx, value);
		}

		[Ordinal(12)] 
		[RED("subUVy")] 
		public CUInt32 SubUVy
		{
			get => GetProperty(ref _subUVy);
			set => SetProperty(ref _subUVy, value);
		}

		[Ordinal(13)] 
		[RED("frame")] 
		public CUInt32 Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(14)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetProperty(ref _fadeOutTime);
			set => SetProperty(ref _fadeOutTime, value);
		}

		[Ordinal(15)] 
		[RED("fadeInTime")] 
		public CFloat FadeInTime
		{
			get => GetProperty(ref _fadeInTime);
			set => SetProperty(ref _fadeInTime, value);
		}
	}
}
