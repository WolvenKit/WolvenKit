using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entMorphTargetSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(10)] 
		[RED("morphResource")] 
		public CResourceAsyncReference<MorphTargetMesh> MorphResource
		{
			get => GetPropertyValue<CResourceAsyncReference<MorphTargetMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<MorphTargetMesh>>(value);
		}

		[Ordinal(11)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("castShadows")] 
		public CBool CastShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("HACK_isMaterialPriorityBumped")] 
		public CBool HACK_isMaterialPriorityBumped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("castLocalShadows")] 
		public CBool CastLocalShadows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(17)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public entMorphTargetSkinnedMeshComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			MeshAppearance = "default";
			CastShadows = true;
			CastLocalShadows = true;
			AcceptDismemberment = true;
			ChunkMask = 18446744073709551615;
			IsEnabled = true;
			Tags = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
