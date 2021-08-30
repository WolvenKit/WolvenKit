using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearancePartComponentOverrides : RedBaseClass
	{
		private CName _componentName;
		private CName _meshAppearance;
		private CUInt64 _chunkMask;
		private CBool _useCustomTransform;
		private Transform _initialTransform;
		private Vector3 _visualScale;
		private CBool _acceptDismemberment;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(2)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetProperty(ref _chunkMask);
			set => SetProperty(ref _chunkMask, value);
		}

		[Ordinal(3)] 
		[RED("useCustomTransform")] 
		public CBool UseCustomTransform
		{
			get => GetProperty(ref _useCustomTransform);
			set => SetProperty(ref _useCustomTransform, value);
		}

		[Ordinal(4)] 
		[RED("initialTransform")] 
		public Transform InitialTransform
		{
			get => GetProperty(ref _initialTransform);
			set => SetProperty(ref _initialTransform, value);
		}

		[Ordinal(5)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get => GetProperty(ref _visualScale);
			set => SetProperty(ref _visualScale, value);
		}

		[Ordinal(6)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetProperty(ref _acceptDismemberment);
			set => SetProperty(ref _acceptDismemberment, value);
		}

		public appearancePartComponentOverrides()
		{
			_meshAppearance = "default";
			_chunkMask = 18446744073709551615;
			_acceptDismemberment = true;
		}
	}
}
