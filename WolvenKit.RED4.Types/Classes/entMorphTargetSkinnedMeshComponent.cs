using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMorphTargetSkinnedMeshComponent : entISkinTargetComponent
	{
		private CResourceAsyncReference<MorphTargetMesh> _morphResource;
		private CName _meshAppearance;
		private CBool _castShadows;
		private CBool _hACK_isMaterialPriorityBumped;
		private CBool _castLocalShadows;
		private CBool _acceptDismemberment;
		private CUInt64 _chunkMask;
		private CName _renderingPlaneAnimationParam;
		private CName _visibilityAnimationParam;
		private CBool _isEnabled;
		private redTagList _tags;

		[Ordinal(10)] 
		[RED("morphResource")] 
		public CResourceAsyncReference<MorphTargetMesh> MorphResource
		{
			get => GetProperty(ref _morphResource);
			set => SetProperty(ref _morphResource, value);
		}

		[Ordinal(11)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(12)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(13)] 
		[RED("HACK_isMaterialPriorityBumped")] 
		public CBool HACK_isMaterialPriorityBumped
		{
			get => GetProperty(ref _hACK_isMaterialPriorityBumped);
			set => SetProperty(ref _hACK_isMaterialPriorityBumped, value);
		}

		[Ordinal(14)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(15)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetProperty(ref _acceptDismemberment);
			set => SetProperty(ref _acceptDismemberment, value);
		}

		[Ordinal(16)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetProperty(ref _chunkMask);
			set => SetProperty(ref _chunkMask, value);
		}

		[Ordinal(17)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get => GetProperty(ref _renderingPlaneAnimationParam);
			set => SetProperty(ref _renderingPlaneAnimationParam, value);
		}

		[Ordinal(18)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetProperty(ref _visibilityAnimationParam);
			set => SetProperty(ref _visibilityAnimationParam, value);
		}

		[Ordinal(19)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(20)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}
	}
}
